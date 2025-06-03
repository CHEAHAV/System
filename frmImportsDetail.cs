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

namespace Systems
{
    public partial class frmImportsDetail : Form
    {

        Database db = new Database();
        SqlDataAdapter dap;
        SqlDependency dep;
        DataTable dt;
        SqlCommand com;
        decimal Total = 0;

        public frmImportsDetail()
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
            lisImport.Columns.Add("Quantity", 100);
            lisImport.Columns.Add("Price", 100);
            lisImport.Columns.Add("Amount", 200);
            Total = 0;

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboStaffID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtStaffName.Text = cboStaffID.SelectedValue.ToString();
        }

        private void cboSupplierName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtSupplierID.Text = cboSupplierName.SelectedValue.ToString();
        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {
            com = new SqlCommand("spGetNameProduct", db.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ProCode", txtProductCode.Text);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtProductName.Text = dr["ProName"].ToString();
                    txtUnitPrice.Text = "$  " + dr["UPIS"].ToString();
                }
            }
            else
            {
                txtProductName.Text = null;
                txtUnitPrice.Text = null;
            }
            dr.Dispose();
            com.Dispose();
        }


        private void btnSearchImports_Click(object sender, EventArgs e)
        {
            // Fix: ListView does not have a DataSource property. Replace with appropriate logic to filter items manually.  
            var searchText = txtSearch.Text.ToLower();
            var filteredItems = new List<ListViewItem>();

            foreach (ListViewItem item in lisImport.Items)
            {
                if (item.SubItems[1].Text.ToLower().Contains(searchText) || item.SubItems[0].Text.ToLower().Contains(searchText))
                {
                    filteredItems.Add(item);
                }
            }

            lisImport.Items.Clear();
            lisImport.Items.AddRange(filteredItems.ToArray());

            if (lisImport.Items.Count > 0)
            {
                var item = lisImport.Items[0];
                txtImportCode.Text = item.SubItems[0].Text;
                dateImportDate.Text = item.SubItems[1].Text;
                cboStaffID.Text = item.SubItems[2].Text;
                txtStaffName.Text = item.SubItems[3].Text;
                txtSupplierID.Text = item.SubItems[4].Text;
                cboSupplierName.Text = item.SubItems[5].Text;
                txtProductCode.Text = item.SubItems[6].Text;
                txtProductName.Text = item.SubItems[7].Text;
                txtQty.Text = item.SubItems[8].Text;
                txtUnitPrice.Text = item.SubItems[9].Text;
                txtTotal.Text = item.SubItems[10].Text;
            }
            else
            {
                txtImportCode.Clear();
                dateImportDate.Text = null;
                cboStaffID.Text = null;
                txtStaffName.Clear();
                txtSupplierID.Clear();
                cboSupplierName.Text = null;
                txtProductCode.Clear();
                txtProductName.Clear();
                txtQty.Clear();
                txtUnitPrice.Clear();
                txtTotal.Clear();
            }

            txtSearch.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductCode.Text) || string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(txtQty.Text) || string.IsNullOrWhiteSpace(txtUnitPrice.Text) ||
                !int.TryParse(txtQty.Text, out int qty) || qty <= 0 ||
                !decimal.TryParse(txtUnitPrice.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal unitPrice) || unitPrice <= 0)
            {
                MessageBox.Show("Invalid input.");
                return;
            }

            var lv = lisImport.FindItemWithText(txtProductCode.Text);

            if (lv != null && int.TryParse(lv.SubItems[2].Text, out int currentQty) &&
                decimal.TryParse(lv.SubItems[4].Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal oldAmount))
            {
                int newQty = currentQty + qty;
                var amount = newQty * unitPrice; // Use total quantity
                lv.SubItems[2].Text = newQty.ToString();
                lv.SubItems[4].Text = amount.ToString("C");
                Total = Total - oldAmount + amount;
            }
            else
            {
                var amount = qty * unitPrice;
                lisImport.Items.Add(new ListViewItem(new[]
                {
            txtProductCode.Text, txtProductName.Text, qty.ToString(),
            unitPrice.ToString("C"), amount.ToString("C")
        }));
                Total += amount;
            }

            txtTotal.Text = Total.ToString("C");
            txtProductCode.Text = txtProductName.Text = txtQty.Text = txtUnitPrice.Text = "";
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
            if (lisImport.SelectedItems.Count > 0)
            {
                var item = lisImport.SelectedItems[0];
                txtProductCode.Text = item.SubItems[0].Text;
                txtProductName.Text = item.SubItems[1].Text;
                txtQty.Text = item.SubItems[2].Text;
                txtUnitPrice.Text = item.SubItems[3].Text;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var total = Decimal.Parse(txtTotal.Text, NumberStyles.Currency);
            com = new SqlCommand("spsetImports",db.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@impDate",dateImportDate.Value);
            com.Parameters.AddWithValue("@staffID", cboStaffID.Text);
            com.Parameters.AddWithValue("@fullName", txtStaffName.Text);
            com.Parameters.AddWithValue("@supID", txtSupplierID.Text);
            com.Parameters.AddWithValue("@supplier", cboSupplierName.Text);
            com.Parameters.AddWithValue("@total", total);

            MessageBox.Show("Save");

            com.ExecuteNonQuery();
        }
    }
}
