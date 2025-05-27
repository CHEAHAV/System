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
    public partial class frmSuppliers : Form
    {

        Database db = new Database();
        SqlCommand com;
        SqlDependency dep;
        SqlDataAdapter dap;
        DataTable dt;

        public frmSuppliers()
        {
            InitializeComponent();
            db.SystemConnection();
            LoadData();
        }

        public void LoadData()
        {
            dgvSuppliers.DataSource = null;
            com = new SqlCommand("spGetAllSuppliers", db.con);
            com.CommandType = CommandType.StoredProcedure;

            dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(OnChange);

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);

            dgvSuppliers.DataSource = dt;
        }

        public void OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                dgvSuppliers.BeginInvoke(new MethodInvoker(LoadData));
            }
            else
            {
                LoadData();
            }
        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (dgvSuppliers.DataSource as DataTable).DefaultView.RowFilter = string.Format("CONVERT(supID, System.String) LIKE '{0}' OR Supplier LIKE '%{0}%' OR SupAdd LIKE '{0}' ", txtSearch.Text);

            int i;
            if (dgvSuppliers.RowCount > 0 && dgvSuppliers.CurrentRow != null)
            {
                i = dgvSuppliers.CurrentRow.Index;

                DataGridViewRow row = dgvSuppliers.Rows[i];
                txtSupId.Text = row.Cells["supID"].Value.ToString();
                txtSupplierName.Text = row.Cells["Supplier"].Value.ToString();
                txtSupplierAddress.Text = row.Cells["SupAdd"].Value.ToString();
                txtSupplierContact.Text = row.Cells["SupCon"].Value.ToString();

            }
            else
            { 
                txtSupId.Clear();
                txtSupplierName.Clear();
                txtSupplierAddress.Clear();
                txtSupplierContact.Clear();
            }

            txtSearch.Clear();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("spSetSuppliers", db.con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@Supplier", txtSupplierName.Text);
            com.Parameters.AddWithValue("@SupAdd", txtSupplierAddress.Text);
            com.Parameters.AddWithValue("@SupCon", txtSupplierContact.Text);

            com.ExecuteNonQuery();
            MessageBox.Show("Supplier Add Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtSupplierName.Clear();
            txtSupplierAddress.Clear();
            txtSupplierContact.Clear();

            txtSupplierName.Focus();
        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (dgvSuppliers.RowCount > 0)
            { 
                i = e.RowIndex;

                if (i < 0) return;

                DataGridViewRow row = new DataGridViewRow();
                row = dgvSuppliers.Rows[i];

                txtSupId.Text = row.Cells["supID"].Value.ToString();
                txtSupplierName.Text = row.Cells["Supplier"].Value.ToString();
                txtSupplierAddress.Text = row.Cells["SupAdd"].Value.ToString();
                txtSupplierContact.Text = row.Cells["SupCon"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("spUpdateSuppliers", db.con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@supID", txtSupId.Text);
            com.Parameters.AddWithValue("@Supplier", txtSupplierName.Text);
            com.Parameters.AddWithValue("@SupAdd", txtSupplierAddress.Text);
            com.Parameters.AddWithValue("@SupCon", txtSupplierContact.Text);

            com.ExecuteNonQuery();
            MessageBox.Show("Supplier Updated...!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            txtSupId.Clear();
            txtSupplierName.Clear();
            txtSupplierAddress.Clear();
            txtSupplierContact.Clear();

            txtSupplierName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete it?","Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                com = new SqlCommand("spDeleteSuppliers", db.con);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("supID", txtSupId.Text);
                com.ExecuteNonQuery();

                MessageBox.Show("Supplier deleted...!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtSupId.Clear();
                txtSupplierName.Clear();
                txtSupplierAddress.Clear();
                txtSupplierContact.Clear();
            }
            else
            {
                return;
            }
        }
    }
}
