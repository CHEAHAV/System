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

namespace Systems
{
    public partial class frmImports : Form
    {

        Database db = new Database();
        SqlDataAdapter dap;
        SqlDependency dep;
        DataTable dt;
        SqlCommand com;

        public frmImports()
        {
            InitializeComponent();
            db.SystemConnection();
            LoadData();
        }

        public void LoadData()
        {
            dgvImports.DataSource = null;
            com = new SqlCommand("spGetAllImports", db.con);
            com.CommandType = CommandType.StoredProcedure;

            dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(OnChange);

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);

            dgvImports.DataSource = dt;
        }

        public void OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                dgvImports.BeginInvoke(new MethodInvoker(LoadData));
            }
            else
            {
                LoadData();
            }
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

        }

        private void CalculateTotal()
        {
            try
            {
                // Check if both fields have valid input
                if (string.IsNullOrWhiteSpace(txtQty.Text) || string.IsNullOrWhiteSpace(txtUnitPrice.Text))
                {
                    txtTotal.Text = "$  " + "0.00";
                    return;
                }

                // Clean the unit price (remove "$" and spaces)
                string cleanedUnitPrice = txtUnitPrice.Text.Replace("$", "").Trim();

                // Parse inputs
                if (decimal.TryParse(txtQty.Text, out decimal qty) &&
                    decimal.TryParse(cleanedUnitPrice, out decimal unitPrice))
                {
                    decimal total = qty * unitPrice;
                    txtTotal.Text = "$  " + total.ToString("F2"); // Format to 2 decimal places
                }
                else
                {
                    txtTotal.Text = "$  " + "0.00";
                }
            }
            catch (Exception)
            {
                txtTotal.Text = "0 Railway";
            }
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
            com = new SqlCommand("SELECT ProName, UPIS FROM tb_Products WHERE ProCode ='" +txtProductCode.Text+"'",db.con);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        { 
            CalculateTotal();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void dgvImports_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (dgvImports.Rows.Count > 0)
            {
                i = e.RowIndex;
                if (i < 0) return;

                DataGridViewRow row = dgvImports.Rows[i];
                txtImportCode.Text = row.Cells["ImpCode"].Value.ToString();
                dateImportDate.Text = row.Cells["ImpDate"].Value.ToString();
                cboStaffID.Text = row.Cells["staffID"].Value.ToString();
                txtStaffName.Text = row.Cells["FullName"].Value.ToString();
                txtSupplierID.Text = row.Cells["supID"].Value.ToString();
                cboSupplierName.Text = row.Cells["Supplier"].Value.ToString();
                txtProductCode.Text = row.Cells["ProCode"].Value.ToString();
                txtProductName.Text = row.Cells["ProName"].Value.ToString();
                txtQty.Text = row.Cells["Qty"].Value.ToString();
                txtUnitPrice.Text = row.Cells["UPIS"].Value.ToString();
                txtTotal.Text = row.Cells["Total"].Value.ToString();
            }
        }

        private void btnSearchImports_Click(object sender, EventArgs e)
        {

            (dgvImports.DataSource as DataTable).DefaultView.RowFilter = string.Format("FullName LIKE '%{0}%' OR CONVERT(ImpCode, 'System.String') LIKE '{0}'", txtSearch.Text);

            int i;
            if (dgvImports.RowCount > 0 && dgvImports.CurrentRow != null)
            {
                i = dgvImports.CurrentRow.Index;

                DataGridViewRow row = new DataGridViewRow();
                row = dgvImports.Rows[i];
                txtImportCode.Text = row.Cells["ImpCode"].Value.ToString();
                dateImportDate.Text = row.Cells["ImpDate"].Value.ToString();
                cboStaffID.Text = row.Cells["staffID"].Value.ToString();
                txtStaffName.Text = row.Cells["FullName"].Value.ToString();
                txtSupplierID.Text = row.Cells["supID"].Value.ToString();
                cboSupplierName.Text = row.Cells["Supplier"].Value.ToString();
                txtProductCode.Text = row.Cells["ProCode"].Value.ToString();
                txtProductName.Text = row.Cells["ProName"].Value.ToString();
                txtQty.Text = row.Cells["Qty"].Value.ToString();
                txtUnitPrice.Text = row.Cells["UPIS"].Value.ToString();
                txtTotal.Text = row.Cells["Total"].Value.ToString();
            }
            else
            {
                txtImportCode.Clear();
                dateImportDate.Text = null;
                cboStaffID.Text= null;
                txtStaffName.Clear();
                txtSupplierID.Clear();
                cboSupplierName.Text= null;
                txtProductCode.Clear();
                txtProductName.Clear();
                txtQty.Clear();
                txtUnitPrice.Clear();
                txtTotal.Clear();
            }

            txtSearch.Clear();
        }
    }
}
