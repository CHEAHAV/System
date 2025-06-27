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
    public partial class frmCustomer : Form
    {

        Database db = new Database();
        SqlCommand com;
        SqlDependency dep;
        SqlDataAdapter dap;
        DataTable dt;

        public frmCustomer()
        {   
            InitializeComponent();
            db.SystemConnection();
            LoadData();
        }

        public void LoadData()
        {
            dgvCustomer.DataSource = null;
            com = new SqlCommand("spGetAllCustomers", db.con);
            com.CommandType = CommandType.StoredProcedure;

            dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(OnChange);

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);

            dgvCustomer.DataSource = dt;
        }

        public void OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                dgvCustomer.BeginInvoke(new MethodInvoker(LoadData));
            }
            else
            {
                LoadData();
            }
        }


        private void btnExitCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPOS pos = new frmPOS();
            pos.Show();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("spSetCustomers", db.con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("CusName", txtCustomerName.Text);
            com.Parameters.AddWithValue("CusContact", txtCustomerContact.Text);
            com.ExecuteNonQuery();
            MessageBox.Show("Customer Add success...!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCusID.Clear();
            txtCustomerName.Clear();
            txtCustomerContact.Clear();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("spUpdateCustomers", db.con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("CusID", txtCusID.Text);
            com.Parameters.AddWithValue("CusName", txtCustomerName.Text);
            com.Parameters.AddWithValue("CusContact", txtCustomerContact.Text);
            com.ExecuteNonQuery();

            MessageBox.Show("Customers Updated...!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCusID.Clear();
            txtCustomerName.Clear();
            txtCustomerContact.Clear();
            txtCustomerName.Focus();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            if (dgvCustomer.Rows.Count > 0)
            { 
                i = e.RowIndex;
                if (i < 0) return;

                DataGridViewRow row = dgvCustomer.Rows[i];
                txtCusID.Text = row.Cells["CusID"].Value.ToString();
                txtCustomerName.Text = row.Cells["CusName"].Value.ToString();
                txtCustomerContact.Text = row.Cells["CusContact"].Value.ToString();
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            (dgvCustomer.DataSource as DataTable).DefaultView.RowFilter = string.Format("CusName LIKE '%{0}%' OR Convert( CusID, 'System.String') LIKE '{0}'", txtSearch.Text);

            int i;
            if (dgvCustomer.Rows.Count > 0 && dgvCustomer.CurrentRow != null)
            {
                i = dgvCustomer.CurrentRow.Index;

                DataGridViewRow row = dgvCustomer.Rows[i];
                txtCusID.Text = row.Cells["CusID"].Value.ToString();
                txtCustomerName.Text = row.Cells["CusName"].Value.ToString();
                txtCustomerContact.Text = row.Cells["CusContact"].Value.ToString();
            }
            else
            {
                txtSearch.Clear();
                txtCusID.Clear();
                txtCustomerName.Clear();
                txtCustomerContact.Clear();
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete it?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                com = new SqlCommand("spDeleteCustomers", db.con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("CusID", txtCusID.Text);
                com.ExecuteNonQuery();

                MessageBox.Show("Customer deleted...!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCusID.Clear();
                txtCustomerName.Clear();
                txtCustomerContact.Clear();
                txtCustomerName.Focus();
            }
        }
    }
}
