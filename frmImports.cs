using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace Systems
{
    public partial class frmImports : Form
    {
        Database db = new Database();
        SqlDataAdapter dap;
        SqlDependency dep;
        DataTable dt;
        SqlCommand com;
        decimal Total = 0;

        string fp;
        byte[] photos;

        public frmImports()
        {
            InitializeComponent();
            db.SystemConnection();
        }

        private void frmImports_Load(object sender, EventArgs e)
        {
            dap = new SqlDataAdapter("SELECT * FROM fnGetAllStaffs()", db.con);
            dt = new DataTable();
            dap.Fill(dt);

            cboStaffID.DataSource = null;
            cboStaffID.Items.Clear();

            cboStaffID.DataSource = dt;
            cboStaffID.DisplayMember = "staffID";
            cboStaffID.ValueMember = "fullName";

            cboStaffID.Text = null;

            dap = new SqlDataAdapter("SELECT * FROM fnGetAllSuppliers()", db.con);
            dt = new DataTable();
            dap.Fill(dt);

            cboSupplierName.DataSource = null;
            cboSupplierName.Items.Clear();

            cboSupplierName.DataSource = dt;
            cboSupplierName.DisplayMember = "Supplier";
            cboSupplierName.ValueMember = "SupID";

            cboSupplierName.Text = null;

            lisImport.Clear();
            lisImport.View = View.Details;
            lisImport.FullRowSelect = true; // Enable clicking entire row to select
            lisImport.MultiSelect = false; // Allow only one item to be selected
            lisImport.Columns.Add("Product ID", 200);
            lisImport.Columns.Add("Product Name", 200);
            lisImport.Columns.Add("Product Picture", 200);
            lisImport.Columns.Add("Quantity", 100);
            lisImport.Columns.Add("Price", 100);
            lisImport.Columns.Add("Amount", 200);
            Total = 0;
            txtTotal.Text = Total.ToString("C");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPOS pos = new frmPOS();
            pos.Show();
        }

        private void cboStaffID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtStaffName.Text = cboStaffID.SelectedValue?.ToString() ?? string.Empty;
        }

        private void cboSupplierName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtSupplierID.Text = cboSupplierName.SelectedValue?.ToString() ?? string.Empty;
        }

        private void txtProductCode_Leave(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProductCode.Text)) return;

                if (db.con.State != ConnectionState.Open) db.con.Open();
                com = new SqlCommand("spGetNameProduct", db.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ProCode", txtProductCode.Text);

                using (var dr = com.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        txtProductName.Text = dr.IsDBNull(0) ? string.Empty : dr.GetString(0); // ProductName
                        if (!dr.IsDBNull(2)) // Photos column
                        {
                            photos = (byte[])dr[2];
                            using (MemoryStream ms = new MemoryStream(photos))
                            {
                                picImports.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            picImports.Image = null; // No image
                        }
                    }
                    else
                    {
                        txtProductName.Text = string.Empty;
                        picImports.Image = null; // Clear if no product found
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error fetching product: " + ex.Message);
                picImports.Image = null;
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Error casting image data: " + ex.Message);
                picImports.Image = null;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Invalid image data: " + ex.Message);
                picImports.Image = null;
            }
            finally
            {
                if (db.con.State == ConnectionState.Open) db.con.Close();
                com?.Dispose();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProductCode.Text) || string.IsNullOrWhiteSpace(txtQty.Text) || string.IsNullOrWhiteSpace(txtUnitPrice.Text))
                {
                    MessageBox.Show("Please fill all fields.");
                    return;
                }

                decimal amount, price;
                if (!decimal.TryParse(txtUnitPrice.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out price))
                {
                    MessageBox.Show("Invalid price format.");
                    return;
                }

                int qty;
                if (!int.TryParse(txtQty.Text, out qty))
                {
                    MessageBox.Show("Invalid quantity format.");
                    return;
                }

                ListViewItem lvi = null;
                foreach (ListViewItem item in lisImport.Items)
                {
                    if (item.Text.Equals(txtProductCode.Text, StringComparison.Ordinal))
                    {
                        lvi = item;
                        break;
                    }
                }

                if (lvi != null)
                {
                    var newQty = int.Parse(lvi.SubItems[3].Text) + qty;
                    lvi.SubItems[3].Text = newQty.ToString();
                    Total -= decimal.Parse(lvi.SubItems[4].Text, NumberStyles.Currency, CultureInfo.CurrentCulture);
                    amount = newQty * price;
                    lvi.SubItems[4].Text = amount.ToString("C");
                    lvi.SubItems[5].Text = amount.ToString("C");
                    Total += amount;
                }
                else
                {
                    ListViewItem item;
                    string[] arr = new string[6];
                    arr[0] = txtProductCode.Text;
                    arr[1] = txtProductName.Text;
                    arr[2] = fp != null ? fp : "no-image"; // Use path or fallback
                    arr[3] = qty.ToString();
                    arr[4] = price.ToString("C");
                    amount = qty * price;
                    arr[5] = amount.ToString("C");

                    item = new ListViewItem(arr);
                    lisImport.Items.Add(item);
                    Total += amount;
                }

                txtTotal.Text = Total.ToString("C");
                txtProductCode.Text = string.Empty;
                txtProductName.Text = string.Empty;
                txtQty.Text = string.Empty;
                txtUnitPrice.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding item: " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lisImport.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to remove.");
                return;
            }

            var item = lisImport.SelectedItems[0];
            if (MessageBox.Show("Do you want to remove this item?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (decimal.TryParse(item.SubItems[4].Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal amount))
                {
                    Total -= amount;
                    lisImport.Items.Remove(item);
                    txtTotal.Text = Total.ToString("C");
                }
                else
                {
                    MessageBox.Show("Invalid amount format.");
                }
            }
        }

        private void lisImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (lisImport.SelectedItems.Count > 0)
                {
                    var item = lisImport.SelectedItems[0];
                    txtProductCode.Text = item.SubItems[0].Text;
                    txtProductName.Text = item.SubItems[1].Text;

                    // Handle image from file path
                    string imagePath = item.SubItems[2].Text;
                    if (!string.IsNullOrEmpty(imagePath) && imagePath != "no-image" && File.Exists(imagePath))
                    {
                        picImports.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        picImports.Image = null; // No image or invalid path
                    }

                    txtQty.Text = item.SubItems[3].Text;
                    txtUnitPrice.Text = item.SubItems[4].Text;
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Image file not found: " + ex.Message);
                picImports.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading item data: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.con.State != ConnectionState.Open) db.con.Open();

                DataTable dtMaster = new DataTable();
                dtMaster.Columns.Add("ImpDate", typeof(string));
                dtMaster.Columns.Add("StaffID", typeof(int));
                dtMaster.Columns.Add("FullName", typeof(string));
                dtMaster.Columns.Add("SupID", typeof(int));
                dtMaster.Columns.Add("Supplier", typeof(string));
                dtMaster.Columns.Add("Total", typeof(float));

                string ImpDate = dateImportDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
                dtMaster.Rows.Add(DateTime.Parse(ImpDate), int.Parse(cboStaffID.Text), txtStaffName.Text, int.Parse(txtSupplierID.Text), cboSupplierName.Text, (float)Total);

                DataTable dtDetail = new DataTable();
                dtDetail.Columns.Add("ProCode", typeof(string));
                dtDetail.Columns.Add("ProName", typeof(string));
                dtDetail.Columns.Add("Picture", typeof(byte[]));
                dtDetail.Columns.Add("Qty", typeof(int));
                dtDetail.Columns.Add("Price", typeof(float));
                dtDetail.Columns.Add("Amount", typeof(float));

                foreach (ListViewItem item in lisImport.Items)
                {
                    string pCode = item.Text;
                    string pName = item.SubItems[1].Text;
                    string picturePath = item.SubItems[2].Text;
                    byte[] pictureData;
                    if (picturePath == "no-image" || !File.Exists(picturePath))
                    {
                        pictureData = new byte[0]; // or DBNull.Value if you want to allow NULL
                    }
                    else
                    {
                        pictureData = File.ReadAllBytes(picturePath);
                    }
                    int qty = int.Parse(item.SubItems[3].Text);
                    float price = float.Parse(item.SubItems[4].Text, NumberStyles.Currency);
                    float amount = float.Parse(item.SubItems[5].Text, NumberStyles.Currency);

                    dtDetail.Rows.Add(pCode, pName, pictureData, qty, price, amount);
                }

                com = new SqlCommand("spsetImports", db.con);
                com.CommandType = CommandType.StoredProcedure;

                SqlParameter pMaster = new SqlParameter();
                pMaster.ParameterName = "@IMaster";
                pMaster.SqlDbType = SqlDbType.Structured;
                pMaster.Value = dtMaster;
                com.Parameters.Add(pMaster);

                SqlParameter pDetail = new SqlParameter();
                pDetail.ParameterName = "@IDetail";
                pDetail.SqlDbType = SqlDbType.Structured;
                pDetail.Value = dtDetail;
                com.Parameters.Add(pDetail);

                com.ExecuteNonQuery();

                MessageBox.Show("Save Success...!");
                lisImport.Items.Clear();
                txtTotal.Text = "0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
            finally
            {
                if (db.con.State == ConnectionState.Open) db.con.Close();
            }
        }

        private void btnImportsBrows_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            fd.Title = "Select Image";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fp = fd.FileName;
                picImports.Image = Image.FromFile(fp);
            }
        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductCode.Text))
            {
                picImports.Image = null;
            }
        }
    }
}