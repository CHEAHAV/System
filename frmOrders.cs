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
        decimal Total = 0;

        public frmOrders()
        {
            InitializeComponent();
            db.SystemConnection();
        }


        private void btnExitOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPOS pos = new frmPOS();
            pos.Show();
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

            dap = new SqlDataAdapter("SELECT * FROM fnGetAllProducts()", db.con);
            dt = new DataTable();
            dap.Fill(dt);

            cboProductName.DataSource = null;
            cboProductName.Items.Clear();

            cboProductName.DataSource = dt;
            cboProductName.DisplayMember = "ProName";
            cboProductName.ValueMember = "ProCode";

            cboProductName.Text = null;

            lisOrders.Clear();
            lisOrders.View = View.Details;
            lisOrders.FullRowSelect = true; // Enable clicking entire row to select
            lisOrders.MultiSelect = false; // Allow only one item to be selected
            lisOrders.Columns.Add("Product's Code", 200);
            lisOrders.Columns.Add("Product's Name", 200);
            lisOrders.Columns.Add("Quantity", 110);
            lisOrders.Columns.Add("Price", 100);
            lisOrders.Columns.Add("Amount", 200);
            Total = 0;

        }

        private void cboStaffID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtStaffName.Text = cboStaffID.SelectedValue.ToString();
        }

        private void cboCusID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtOrdersCustomerName.Text = cboCusID.SelectedValue.ToString();
        }

        private void cboProductName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtProductCode.Text = cboProductName.SelectedValue.ToString();

        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {
            com = new SqlCommand("spGetNameProduct", db.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ProCode", txtProductCode.Text);
            var dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtUnitPrice.Text = string.Format("{0:c}", Decimal.Parse(dr["SUP"].ToString()));

                }
            }
            else
            {
                txtUnitPrice.Text = null;
            }
            dr.Dispose();
            com.Dispose();
        }

        private void btnAddOrders_Click(object sender, EventArgs e)
        {
            Decimal amount, s;

            ListViewItem lvi = null;
            foreach (ListViewItem item in lisOrders.Items)
            {
                if (item.Text.Equals(txtProductCode.Text, StringComparison.Ordinal))
                {
                    lvi = item;
                    break;
                }
            }

            if (lvi != null)
            {
                var qty = int.Parse(lvi.SubItems[2].Text) + int.Parse(txtQty.Text);
                lvi.SubItems[2].Text = qty.ToString();
                Total = Total - decimal.Parse(lvi.SubItems[4].Text, NumberStyles.Currency);
                var price = decimal.Parse(txtUnitPrice.Text, NumberStyles.Currency);
                amount = qty * price;
                lvi.SubItems[4].Text = string.Format("{0:c}", amount);
                Total = amount + Total;
            }
            else
            {
                ListViewItem item;
                string[] arr = new string[5];
                arr[0] = txtProductCode.Text;
                arr[1] = cboProductName.Text;
                arr[2] = txtQty.Text;
                s = decimal.Parse(txtUnitPrice.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat);
                arr[3] = string.Format("{0:c}", s);
                amount = decimal.Parse(txtQty.Text) * decimal.Parse(txtUnitPrice.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat);
                arr[4] = string.Format("{0:c}", amount);

                item = new ListViewItem(arr);
                lisOrders.Items.Add(item);
                Total = Total + amount;
            }

            txtOrderTotal.Text = string.Format("{0:c}", Total);
            
            txtProductCode.Text = null;
            cboProductName.Text = null;
            txtQty.Text = null;
            txtUnitPrice.Text = null;

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lisOrders.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to remove.");
                return;
            }

            var item = lisOrders.SelectedItems[0];
            if (MessageBox.Show("Do you want to remove this item?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (decimal.TryParse(item.SubItems[4].Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal amount))
                {
                    Total -= amount;
                    lisOrders.Items.Remove(item);
                    txtOrderTotal.Text = Total.ToString("C");
                }
                else
                {
                    MessageBox.Show("Invalid amount format.");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dtMaster = new DataTable();
            dtMaster.Columns.Add("ImpDate", typeof(string));
            dtMaster.Columns.Add("StaffID", typeof(int));
            dtMaster.Columns.Add("FullName", typeof(string));
            dtMaster.Columns.Add("cusID", typeof(int));
            dtMaster.Columns.Add("cusName", typeof(string));
            dtMaster.Columns.Add("Total", typeof(float));

            string ImpDate = dateOrders.Value.ToString("yyyy-MM-dd HH:mm:ss");
            dtMaster.Rows.Add(DateTime.Parse(ImpDate), cboStaffID.Text, txtStaffName.Text, cboCusID.Text, txtOrdersCustomerName.Text, Total);

            DataTable dtDetail = new DataTable();
            dtDetail.Columns.Add("ProCode", typeof(string));
            dtDetail.Columns.Add("ProName", typeof(string));
            dtDetail.Columns.Add("Qty", typeof(int));
            dtDetail.Columns.Add("Price", typeof(float));
            dtDetail.Columns.Add("Amount", typeof(float));

            foreach (ListViewItem item in lisOrders.Items)
            {
                string pCode = item.Text;
                string pName = item.SubItems[1].Text;
                int qty = int.Parse(item.SubItems[2].Text);
                float price = float.Parse(item.SubItems[3].Text, NumberStyles.Currency);
                float amount = float.Parse(item.SubItems[4].Text, NumberStyles.Currency);

                dtDetail.Rows.Add(pCode, pName, qty, price, amount);
            }

            com = new SqlCommand("spsetOrders", db.con);
            com.CommandType = CommandType.StoredProcedure;

            SqlParameter pMaster = new SqlParameter();
            pMaster.ParameterName = "@OMaster";
            pMaster.SqlDbType = SqlDbType.Structured;
            pMaster.Value = dtMaster;
            com.Parameters.Add(pMaster);

            SqlParameter pDetail = new SqlParameter();
            pDetail.ParameterName = "@ODetail";
            pDetail.SqlDbType = SqlDbType.Structured;
            pDetail.Value = dtDetail;
            com.Parameters.Add(pDetail);

            com.ExecuteNonQuery();

            MessageBox.Show("Save Success...!");
            lisOrders.Items.Clear();
            txtOrderTotal.Text = null;
        }
    }
}
