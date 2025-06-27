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

        decimal Total = 0;
        decimal Deposit = 0;
        decimal Remain = 0;

        public frmPayments()
        {
            InitializeComponent();
            db.SystemConnection();
        }

        private void btnExitPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPOS pos = new frmPOS();
            pos.Show();
        }

        private void frmPayments_Load(object sender, EventArgs e)
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

            dap = new SqlDataAdapter("SELECT * FROM fnGetInvoiceCode()", db.con);
            dt = new DataTable();
            dap.Fill(dt);

            cboInvoiceCode.DataSource = null;
            cboInvoiceCode.Items.Clear();

            cboInvoiceCode.DataSource = dt;
            cboInvoiceCode.DisplayMember = "OrdCode";
            cboInvoiceCode.ValueMember = "OrdCode";

            cboInvoiceCode.Text = null;


        }

        private void cboStaffID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtPaymentStaffName.Text = cboStaffID.SelectedValue.ToString();
        }

        private void cboInvoiceCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            com = new SqlCommand("spGetPayment", db.con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@InvoiceCode", cboInvoiceCode.SelectedValue.ToString());

            var dr = com.ExecuteReader();
            if (dr.Read())
            {
                txtTotal.Text = string.Format("{0:c}", Decimal.Parse(dr[0].ToString()));
                txtDeposit.Text = dr[1].ToString();

                if (string.IsNullOrEmpty(txtDeposit.Text))
                {
                    txtRemain.Text = txtTotal.Text;
                }
                else 
                {
                    Total = decimal.Parse(txtTotal.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat);
                    Deposit = decimal.Parse(txtDeposit.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat);

                    Remain = Deposit;
                    lblRemain.Text = "Deposit";
                    txtRemain.Text = string.Format("{0:c}", decimal.Parse(Remain.ToString()));
                    
                    txtDeposit.ReadOnly = true;
                    lblDeposit.Text = "Paid";
                    Deposit = Total - Remain;
                    txtDeposit.Text = string.Format("{0:c}", decimal.Parse(Deposit.ToString()));
                }
            }
            dr.Dispose();
            com.Dispose();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("spGetAllPayments", db.con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@PayDate", datePayment.Value);
            com.Parameters.AddWithValue("@StaffID", cboStaffID.Text);
            com.Parameters.AddWithValue("@FullName", txtPaymentStaffName.Text);
            com.Parameters.AddWithValue("@OrdCode", int.Parse(cboInvoiceCode.SelectedValue.ToString()));

            if (txtDeposit.Enabled == true && txtDeposit.ReadOnly == false)
            {
                com.Parameters.AddWithValue("@Deposit", decimal.Parse(txtDeposit.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat));
            }
            else
            {
                com.Parameters.AddWithValue("@Deposit", float.Parse(txtDeposit.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat));
            }
            com.Parameters.AddWithValue("@Amount", decimal.Parse(txtTotal.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat));
            com.ExecuteNonQuery();
            MessageBox.Show("Paid...!");
           
            cboStaffID.Text = null;
            txtPaymentStaffName.Text = null;
            cboInvoiceCode.Text = null;
            txtTotal.Text = null;
            txtDeposit.Text = null;
            txtRemain.Text = null;

        }
    }
}
