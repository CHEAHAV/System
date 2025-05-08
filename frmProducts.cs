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
    public partial class frmProducts : Form
    {

        Database db = new Database();
        SqlCommand com;
        SqlDependency dep;
        SqlDataAdapter dap;
        DataTable dt;

        public frmProducts()
        {
            InitializeComponent();
            db.SystemConnection();
            LoadData();
        }

        public void LoadData()
        {
            dgvProducts.DataSource = null;
            com = new SqlCommand("spGetAllProducts", db.con);
            com.CommandType = CommandType.StoredProcedure;

            dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(OnChange);

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);

            dgvProducts.DataSource = dt;
        }

        public void OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                dgvProducts.BeginInvoke(new MethodInvoker(LoadData));
            }
            else
            {
                LoadData();
            }
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            (dgvProducts.DataSource as DataTable).DefaultView.RowFilter = string.Format("ProName LIKE '%{0}%' OR CONVERT(ProCode, 'System.String') LIKE '%{0}%'", txtSearch.Text);
            txtSearch.Clear();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            var upis = Decimal.Parse(txtProductUPIS.Text, NumberStyles.Currency);
            var sup = Decimal.Parse(txtProductSUP.Text, NumberStyles.Currency);

            com = new SqlCommand("spSetProducts", db.con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@ProName", txtProductName.Text);
            com.Parameters.AddWithValue("@Qty", txtProductQTY.Text);
            com.Parameters.AddWithValue("@UPIS", upis);
            com.Parameters.AddWithValue("@SUP", sup);

            com.ExecuteNonQuery();
            MessageBox.Show("Staff Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtProductName.Clear();
            txtProductQTY.Clear();
            txtProductUPIS.Clear();
            txtProductSUP.Clear();

            txtProductName.Focus();
        }
    }
}
