using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Systems
{
    public partial class frmOrderDetail : Form
    {
        Database db = new Database();
        SqlCommand com;
        SqlDependency dep;
        SqlDataAdapter dap;
        DataTable dt;

        public frmOrderDetail()
        {
            InitializeComponent();
            db.SystemConnection();
            LoadData();
        }

        public void LoadData()
        {
            dgvOrderDetail.DataSource = null;
            com = new SqlCommand("spGetAllOrderDetail", db.con);
            com.CommandType = CommandType.StoredProcedure;

            dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(OnChange);

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);

            dgvOrderDetail.DataSource = dt;
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            
        }

        public void OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            { 
                dgvOrderDetail.BeginInvoke(new MethodInvoker(LoadData));
            }
            else
            {
                LoadData();
            }
        }

        private void btnExitOrderDetail_Click(object sender, EventArgs e)
        {
            frmPOS pos = new frmPOS();
            pos.Show();
            this.Hide();
        }
    }
}
