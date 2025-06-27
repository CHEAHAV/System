using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            GraphicsPath gpp = new GraphicsPath();
            gpp.AddEllipse(1, 1, btnExit.Width - 3, btnExit.Height - 3);
            btnExit.Region = new Region(gpp);


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

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSuppliers sup = new frmSuppliers();
            sup.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
