using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Systems
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {

        }

        private void btnImports_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmImports ImportDetail = new frmImports();
            ImportDetail.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProducts Product = new frmProducts();
            Product.Show();
        }

        private void btnStaffs_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStaffs Staff = new frmStaffs();
            Staff.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomer Customers = new frmCustomer();
            Customers.Show();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPayments Payments = new frmPayments();
            Payments.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOrders Order = new frmOrders();
            Order.Show();
        }
    }
}
