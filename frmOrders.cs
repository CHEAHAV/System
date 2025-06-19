using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Systems
{
    public partial class frmOrders : Form
    {

        Database db = new Database();
        SqlCommand com;
        SqlDependency dep;
        SqlDataAdapter dap;
        DataTable dt;

        public frmOrders()
        {
            InitializeComponent();
            db.SystemConnection();
            LoadData();
        }

        public void LoadData()
        {
            dgvOrders.DataSource = null;
            com = new SqlCommand("spGetAllOrders", db.con);
            com.CommandType = CommandType.StoredProcedure;

            dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(OnChange);

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);

            dgvOrders.DataSource = dt;


        }

        public void OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                dgvOrders.BeginInvoke( new MethodInvoker(LoadData));
            }
            else
            {
                LoadData();            
            }
        }

        private void frmOrders_Load(object sender, EventArgs e)
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

            dap = new SqlDataAdapter("SELECT * FROM fnGetAllCustomers()", db.con);
            dt = new DataTable();
            dap.Fill(dt);

            cboCusID.DataSource = null;
            cboCusID.Items.Clear();

            cboCusID.DataSource = dt;
            cboCusID.DisplayMember = "cusID";
            cboCusID.ValueMember = "CusName";
            cboCusID.Text = null;
        }

        private void btnExitOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPOS pos = new frmPOS();
            pos.Show();
        }

        private void btnSearchOrders_Click(object sender, EventArgs e)
        {
            (dgvOrders.DataSource as DataTable).DefaultView.RowFilter = string.Format("FullName LIKE '%{0}%' OR Convert(OrdCode, System.String) LIKE '{0}'", txtSearch.Text);

            int i;
            if (dgvOrders.Rows.Count > 0 && dgvOrders.CurrentRow != null)
            {
                i = dgvOrders.CurrentRow.Index;
                DataGridViewRow row = dgvOrders.Rows[i];
                txtOrdersCode.Text = row.Cells["OrdCode"].Value.ToString();
                dateOrders.Text = row.Cells["OrdDate"].Value.ToString();
                cboStaffID.Text = row.Cells["StaffID"].Value.ToString();
                txtOrdersStaffName.Text = row.Cells["FullName"].Value.ToString();
                cboCusID.Text = row.Cells["CusID"].Value.ToString();
                txtOrdersCustomerName.Text = row.Cells["CusName"].Value.ToString();
                txtOrderTotal.Text = row.Cells["Total"].Value.ToString();
            }
            else
            { 
                txtOrdersCode.Clear();
                dateOrders.Text = string.Empty;
                cboStaffID.Text = string.Empty;
                txtOrdersStaffName.Clear();
                cboCusID.Text = string.Empty;
                txtOrdersCustomerName.Clear();
                txtOrderTotal.Clear();
            }

            txtSearch.Clear();
        }

        private void btnAddOrders_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("spSetOrders", db.con);
            com.CommandType = CommandType.StoredProcedure;

            var total = Decimal.Parse(txtOrderTotal.Text,NumberStyles.Currency);

            com.Parameters.AddWithValue("@OrdDate", dateOrders.Value);
            com.Parameters.AddWithValue("@staffID", cboStaffID.Text);
            com.Parameters.AddWithValue("@FullName", txtOrdersStaffName.Text);
            com.Parameters.AddWithValue("@cusID", cboCusID.Text);
            com.Parameters.AddWithValue("@cusName", txtOrdersCustomerName.Text);
            com.Parameters.AddWithValue("@Total", txtOrderTotal.Text);

            com.ExecuteNonQuery();

            MessageBox.Show("Orders Add Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dateOrders = null;
            cboStaffID.Text = string.Empty;
            txtOrdersStaffName.Clear();
            cboCusID.Text = string.Empty;
            txtOrdersCustomerName.Clear();
            txtOrderTotal.Clear();

        }

        private void cboStaffID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtOrdersStaffName.Text = cboStaffID.SelectedValue.ToString();
        }

        private void cboCusID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtOrdersCustomerName.Text = cboCusID.SelectedValue.ToString();
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (dgvOrders.RowCount > 0)
            { 
                i = e.RowIndex;
                if (i < 0) return;

                DataGridViewRow row = dgvOrders.Rows[i];
                txtOrdersCode.Text = row.Cells["OrdCode"].Value.ToString();
                dateOrders.Text = row.Cells["OrdDate"].Value.ToString();
                cboStaffID.Text = row.Cells["StaffID"].Value.ToString();
                txtOrdersStaffName.Text = row.Cells["FullName"].Value.ToString();
                cboCusID.Text = row.Cells["CusID"].Value.ToString();
                txtOrdersCustomerName.Text = row.Cells["CusName"].Value.ToString();
                txtOrderTotal.Text = row.Cells["Total"].Value.ToString();
            }
        }

        private void btnUpdateOrders_Click(object sender, EventArgs e)
        {

        }
    }
}
