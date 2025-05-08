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

        }

        private void btnExitOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchOrders_Click(object sender, EventArgs e)
        {
            (dgvOrders.DataSource as DataTable).DefaultView.RowFilter = string.Format("FullName LIKE '%{0}%'", txtSearch.Text);
            txtSearch.Clear();
        }

        private void btnAddOrders_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("spSetOrders", db.con);
            com.CommandType = CommandType.StoredProcedure;

            var total = Decimal.Parse(txtOrderTotal.Text,NumberStyles.Currency);

            com.Parameters.AddWithValue("@OrdDate", dateOrders.Value);
            com.Parameters.AddWithValue("@staffID", txtOrdersStaffID.Text);
            com.Parameters.AddWithValue("@FullName", txtOrdersStaffName.Text);
            com.Parameters.AddWithValue("@cusID", txtOrdersCustomerID.Text);
            com.Parameters.AddWithValue("@cusName", txtOrdersCustomerName.Text);
            com.Parameters.AddWithValue("@Total", txtOrderTotal.Text);

            com.ExecuteNonQuery();

            MessageBox.Show("Orders Add Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dateOrders = null;
            txtOrdersStaffID.Clear();
            txtOrdersStaffName.Clear();
            txtOrdersCustomerID.Clear();
            txtOrdersCustomerName.Clear();
            txtOrderTotal.Clear();

        }
    }
}
