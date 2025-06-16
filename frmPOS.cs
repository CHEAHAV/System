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
            frmImports ImportDetail = new frmImports();
            ImportDetail.Show();
            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProducts Product = new frmProducts();
            Product.Show();
            this.Hide();
        }

        private void btnStaffs_Click(object sender, EventArgs e)
        {
            frmStaffs Staff = new frmStaffs();
            Staff.Show();
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomer Customers = new frmCustomer();
            Customers.Show();
            this.Hide();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            frmPayments Payments = new frmPayments();
            Payments.Show();
            this.Hide();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            frmOrders Order = new frmOrders();
            Order.Show();
            this.Hide();
        }
    }
}
