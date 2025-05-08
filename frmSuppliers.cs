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
            (dgvSuppliers.DataSource as DataTable).DefaultView.RowFilter = string.Format("CONVERT(supID, System.String) LIKE '%{0}%' OR Supplier LIKE '%{0}%' OR SupAdd LIKE '{0}' ", txtSearch.Text);
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
    }
}
