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
using System.IO;

namespace Systems
{
    public partial class frmProducts : Form
    {

        Database db = new Database();
        SqlCommand com;
        SqlDependency dep;
        SqlDataAdapter dap;
        DataTable dt;

        string fp;
        byte[] photos;
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
            if (dgvProducts.Rows.Count > 0)
            {
                txtProCode.Text = dgvProducts.Rows[0].Cells["ProCode"].Value.ToString();
                txtProductName.Text = dgvProducts.Rows[0].Cells["ProName"].Value.ToString();
                
                if (dgvProducts.Rows[0].Cells["Picture"].Value != DBNull.Value)
                {
                    byte[] pic = (byte[])dgvProducts.Rows[0].Cells["Picture"].Value;
                    MemoryStream ms = new MemoryStream(pic);
                    picProducts.Image = Image.FromStream(ms);
                }
                else
                {
                    picProducts.Image = null;
                
                }
                txtProductQTY.Text = dgvProducts.Rows[0].Cells["Qty"].Value.ToString();
                txtProductUPIS.Text = dgvProducts.Rows[0].Cells["UPIS"].Value.ToString();
                txtProductSUP.Text = dgvProducts.Rows[0].Cells["SUP"].Value.ToString();
            }

            dgvProducts.DefaultCellStyle.Font = new Font("Khmer OS Battambang", 12, FontStyle.Regular);
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dgvProducts.Columns["Picture"];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;


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
            SqlCommand com = new SqlCommand("SELECT dbo.fnCountProduct()", db.con);

            var n = com.ExecuteScalar();
            txtProductsNumber.Text = n.ToString();

            com = new SqlCommand("spST", db.con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("@S", SqlDbType.Int).Direction = ParameterDirection.Output;
            com.Parameters.Add("@T", SqlDbType.Float).Direction = ParameterDirection.Output;

            com.ExecuteNonQuery();
            
            var s = int.Parse(com.Parameters["@S"].Value.ToString());
            var t = float.Parse(com.Parameters["@T"].Value.ToString(), NumberStyles.Currency);

            txtTotalofqty.Text = s.ToString();
            txtTotalAmount.Text = t.ToString("C", CultureInfo.CurrentCulture);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPOS pos = new frmPOS();
            pos.Show();
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

                if (row.Cells["Picture"].Value != DBNull.Value)
                {
                    byte[] img = (byte[])row.Cells["Picture"].Value;
                    MemoryStream ms = new MemoryStream(img);
                    picProducts.Image = Image.FromStream(ms);
                }
                else
                {
                    picProducts.Image = null;
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
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

                if (row.Cells["Picture"].Value != DBNull.Value)
                {
                    byte[] img = (byte[])row.Cells["Picture"].Value;
                    MemoryStream ms = new MemoryStream(img);
                    picProducts.Image = Image.FromStream(ms);
                }
                else
                {
                    picProducts.Image = null;
                }
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
    }
}
