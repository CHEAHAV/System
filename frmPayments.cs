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
    public partial class frmPayments : Form
    {

        Database db = new Database();
        SqlCommand com;
        SqlDependency dep;
        SqlDataAdapter dap;
        DataTable dt;

        public frmPayments()
        {
            InitializeComponent();
            db.SystemConnection();
            LoadData();
        }

        public void LoadData()
        {
            dgvPayment.DataSource = null;
            com = new SqlCommand("spGetAllPayments", db.con);
            com.CommandType = CommandType.StoredProcedure;

            dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(OnChange);

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);

            dgvPayment.DataSource = dt;
        }

        public void OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            {
                dgvPayment.BeginInvoke(new MethodInvoker(LoadData));
            }
            else
            {
                LoadData();
            }
        }

        private void btnExitPayment_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (dgvPayment.RowCount > 0)
            { 
                i = e.RowIndex;
                if (i < 0) return;

                DataGridViewRow row = dgvPayment.Rows[i];
                txtPaymentCode.Text = row.Cells["PayCode"].Value.ToString();
                datePayment.Text = row.Cells["PayDate"].Value.ToString();
                txtStaffID.Text = row.Cells["StaffID"].Value.ToString();
                txtPaymentStaffName.Text = row.Cells["FullName"].Value.ToString();
                cboInvoiceCode.Text = row.Cells["OrdCode"].Value.ToString();
                txtpaymentAmount.Text = row.Cells["Amount"].Value.ToString();
            }
        }

        private void btnSearchpayment_Click(object sender, EventArgs e)
        {
            (dgvPayment.DataSource as DataTable).DefaultView.RowFilter = string.Format("FullName LIKE '%{0}%' OR Convert(PayCode, System.String) LIKE '{0}'", txtSearch.Text);

            int i;
            if (dgvPayment.Rows.Count > 0 && dgvPayment.CurrentRow != null)
            {
                i = dgvPayment.CurrentRow.Index;

                DataGridViewRow row = dgvPayment.Rows[i];
                txtPaymentCode.Text = row.Cells["PayCode"].Value.ToString();
                datePayment.Text = row.Cells["PayDate"].Value.ToString();
                txtStaffID.Text = row.Cells["StaffID"].Value.ToString();
                txtPaymentStaffName.Text = row.Cells["FullName"].Value.ToString();
                cboInvoiceCode.Text = row.Cells["OrdCode"].Value.ToString();
                txtpaymentAmount.Text = row.Cells["Amount"].Value.ToString();

                txtSearch.Clear();
            }
            else
            { 
                txtPaymentCode.Clear();
                datePayment.Text = string.Empty;
                txtStaffID.Text = string.Empty;
                txtPaymentStaffName.Clear();
                cboInvoiceCode.Text = string.Empty;
                txtpaymentAmount.Clear();
                txtSearch.Clear();
            }
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("spsetPayments", db.con);
            com.CommandType = CommandType.StoredProcedure;

            var amount = Decimal.Parse(txtpaymentAmount.Text, NumberStyles.Currency);

            com.Parameters.AddWithValue("@PayDate", datePayment.Value);
            com.Parameters.AddWithValue("@StaffID", txtStaffID.Text);
            com.Parameters.AddWithValue("@FullName", txtPaymentStaffName.Text);
            com.Parameters.AddWithValue("@OrdCode", cboInvoiceCode.Text);
            com.Parameters.AddWithValue("@Amount", amount);
            com.ExecuteNonQuery();

            MessageBox.Show("Payment Add success...!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cboInvoiceCode_TextChanged(object sender, EventArgs e)
        {
            com = new SqlCommand("SELECT staffID, FullName FROM dbo.tb_Orders WHERE OrdCode ='" + cboInvoiceCode.Text + "'", db.con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtStaffID.Text = dr["staffID"].ToString();
                    txtPaymentStaffName.Text = dr["FullName"].ToString();
                }
            }
            else
            {
                txtStaffID.Text = null;
                txtPaymentStaffName.Clear();
            }
            dr.Dispose();
            com.Dispose();
        }

        private void frmPayments_Load(object sender, EventArgs e)
        {
            dap = new SqlDataAdapter("SELECT * FROM fnGetAllOrders()", db.con);
            dt = new DataTable();
            dap.Fill(dt);

            cboInvoiceCode.DataSource = null;
            cboInvoiceCode.Items.Clear();

            cboInvoiceCode.DataSource = dt;
            cboInvoiceCode.DisplayMember = "OrdCode";
            cboInvoiceCode.ValueMember = "Total";
            cboInvoiceCode.Text = null;
        }

        private void cboInvoiceCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtpaymentAmount.Text = "$  " + cboInvoiceCode.SelectedValue.ToString();
        }

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete it?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                com = new SqlCommand("spDeletePayments", db.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@PayCode", txtPaymentCode.Text);
                com.ExecuteNonQuery();

                MessageBox.Show("You deleted...!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtPaymentCode.Clear();
                datePayment.Text = string.Empty;
                txtStaffID.Text = string.Empty;
                txtPaymentStaffName.Clear();
                cboInvoiceCode.Text = string.Empty;
                txtpaymentAmount.Clear();
            }
            else
            {
                MessageBox.Show("You cancel delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnUpdatePayment_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to update it?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                com = new SqlCommand("spUpdatePayments", db.con);
                com.CommandType = CommandType.StoredProcedure;

                var amount = Decimal.Parse(txtpaymentAmount.Text, NumberStyles.Currency);

                com.Parameters.AddWithValue("@PayCode", txtPaymentCode.Text);
                com.Parameters.AddWithValue("@PayDate", datePayment.Value);
                com.Parameters.AddWithValue("@StaffID", txtStaffID.Text);
                com.Parameters.AddWithValue("@FullName", txtPaymentStaffName.Text);
                com.Parameters.AddWithValue("@OrdCode", cboInvoiceCode.Text);
                com.Parameters.AddWithValue("@Amount", amount);
                com.ExecuteNonQuery();


                MessageBox.Show("Update success...!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPaymentCode.Clear();
                datePayment.Text = string.Empty;
                txtStaffID.Text = string.Empty;
                txtPaymentStaffName.Clear();
                cboInvoiceCode.Text = string.Empty;
                txtpaymentAmount.Clear();

            }
            else
            {
                MessageBox.Show("You are cancel update...!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
