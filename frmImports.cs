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
    public partial class frmImports : Form
    {

        Database db = new Database();
        SqlDataAdapter dap;
        SqlDependency dep;
        DataTable dt;
        SqlCommand com;
        decimal Total = 0;

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
            lisImport.Columns.Add("Quantity", 100);
            lisImport.Columns.Add("Price", 100);
            lisImport.Columns.Add("Amount", 200);
            Total = 0;

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPOS pos = new frmPOS();
            pos.Show();
        }

        private void cboStaffID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtStaffName.Text = cboStaffID.SelectedValue.ToString();
        }

        private void cboSupplierName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtSupplierID.Text = cboSupplierName.SelectedValue.ToString();
        }

        private void txtProductCode_Leave(object sender, EventArgs e)
        {
            com = new SqlCommand("spGetNameProduct", db.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ProCode", txtProductCode.Text);
            var dr = com.ExecuteReader();

            txtProductName.Text = dr.Read() ? dr.GetString(0) : null;

            dr.Dispose();
            com.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Decimal amount, s;

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
                var qty = int.Parse(lvi.SubItems[2].Text) + int.Parse(txtQty.Text);
                lvi.SubItems[2].Text = qty.ToString();
                Total = Total - decimal.Parse(lvi.SubItems[4].Text, NumberStyles.Currency);
                var price = decimal.Parse(txtUnitPrice.Text, NumberStyles.Currency);
                amount = qty * price;
                lvi.SubItems[4].Text = string.Format("{0:c}", amount);
                Total = amount + Total;
            }
            else
            {
                ListViewItem item;
                string[] arr = new string[5];
                arr[0] = txtProductCode.Text;
                arr[1] = txtProductName.Text;
                arr[2] = txtQty.Text;
                s = decimal.Parse(txtUnitPrice.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat);
                arr[3] = string.Format("{0:c}", s);
                amount = decimal.Parse(txtQty.Text) * decimal.Parse(txtUnitPrice.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat);
                arr[4] = string.Format("{0:c}", amount);

                item = new ListViewItem(arr);
                lisImport.Items.Add(item);
                Total = Total + amount;
            }

            txtTotal.Text = string.Format("{0:c}", Total);
            
            txtProductCode.Text = null;
            txtProductName.Text = null;
            txtQty.Text = null;
            txtUnitPrice.Text = null;

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

            DataTable dtMaster = new DataTable();
            dtMaster.Columns.Add("ImpDate", typeof(string));
            dtMaster.Columns.Add("StaffID", typeof(int));
            dtMaster.Columns.Add("FullName", typeof(string));
            dtMaster.Columns.Add("SupID", typeof(int));
            dtMaster.Columns.Add("Supplier", typeof(string));
            dtMaster.Columns.Add("Total", typeof(float));

            string ImpDate = dateImportDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
            dtMaster.Rows.Add(DateTime.Parse(ImpDate),cboStaffID.Text, txtStaffName.Text,txtSupplierID.Text, cboSupplierName.Text, Total);

            DataTable dtDetail = new DataTable();
            dtDetail.Columns.Add("ProCode", typeof(string));
            dtDetail.Columns.Add("ProName", typeof(string));
            dtDetail.Columns.Add("Qty", typeof(int));
            dtDetail.Columns.Add("Price", typeof(float));
            dtDetail.Columns.Add("Amount", typeof(float));

            foreach (ListViewItem item in lisImport.Items)
            {
                string pCode = item.Text;
                string pName = item.SubItems[1].Text;
                int qty = int.Parse(item.SubItems[2].Text);
                float price = float.Parse(item.SubItems[3].Text, NumberStyles.Currency);
                float amount = float.Parse(item.SubItems[4].Text, NumberStyles.Currency);

                dtDetail.Rows.Add(pCode, pName, qty, price, amount);
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
            txtTotal.Text = null;

        }

    }
}
