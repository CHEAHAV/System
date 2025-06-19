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
            this.Hide();
            frmPOS pos = new frmPOS();
            pos.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            (dgvProducts.DataSource as DataTable).DefaultView.RowFilter = string.Format("ProName LIKE '%{0}%' OR CONVERT(ProCode, 'System.String') LIKE '{0}'", txtSearch.Text);

            int i;
            if (dgvProducts.RowCount > 0 && dgvProducts.CurrentRow != null)
            {
                i = dgvProducts.CurrentRow.Index;

                DataGridViewRow row = new DataGridViewRow();
                row = dgvProducts.Rows[i];
                txtProCode.Text = row.Cells["ProCode"].Value.ToString();
                txtProductName.Text = row.Cells["ProName"].Value.ToString();
                txtProductQTY.Text = row.Cells["Qty"].Value.ToString();
                txtProductUPIS.Text = row.Cells["UPIS"].Value.ToString();
                txtProductSUP.Text = row.Cells["SUP"].Value.ToString();
            }
            else
            {
                txtProCode.Clear();
                txtProductName.Clear();
                txtProductQTY.Clear();
                txtProductUPIS.Clear();
                txtProductSUP.Clear();
            }

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
            MessageBox.Show("Products Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtProCode.Clear();
            txtProductName.Clear();
            txtProductQTY.Clear();
            txtProductUPIS.Clear();
            txtProductSUP.Clear();

            txtProductName.Focus();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (dgvProducts.RowCount > 0)
            { 
                i = e.RowIndex;
                if (i < 0) return;

                DataGridViewRow row = new DataGridViewRow();
                row = dgvProducts.Rows[i];
                txtProCode.Text = row.Cells["ProCode"].Value.ToString();
                txtProductName.Text = row.Cells["ProName"].Value.ToString();
                txtProductQTY.Text = row.Cells["Qty"].Value.ToString();
                txtProductUPIS.Text = row.Cells["UPIS"].Value.ToString();
                txtProductSUP.Text = row.Cells["SUP"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var upis = Decimal.Parse(txtProductUPIS.Text, NumberStyles.Currency);
            var sup = Decimal.Parse(txtProductSUP.Text, NumberStyles.Currency);

            com = new SqlCommand("spUpdateProducts", db.con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@ProCode",txtProCode.Text);
            com.Parameters.AddWithValue("@ProName", txtProductName.Text);
            com.Parameters.AddWithValue("@Qty", txtProductQTY.Text);
            com.Parameters.AddWithValue("@UPIS", upis);
            com.Parameters.AddWithValue("@SUP", sup);
            com.ExecuteNonQuery();
            
            MessageBox.Show("Products Update Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            txtProCode.Clear();
            txtProductName.Clear();
            txtProductQTY.Clear();
            txtProductUPIS.Clear();
            txtProductSUP.Clear();

            txtProductName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete it!", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                com = new SqlCommand("spDeleteProducts", db.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ProCode",txtProCode.Text);
                com.ExecuteNonQuery() ;

                MessageBox.Show("Product deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtProCode.Clear() ;
                txtProductName.Clear();
                txtProductQTY.Clear();
                txtProductUPIS.Clear();
                txtProductSUP.Clear();
                txtProductName.Focus();
            }
        }
    }
}
