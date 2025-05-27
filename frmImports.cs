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

namespace Systems
{
    public partial class frmImports : Form
    {

        Database db = new Database();
        SqlDataAdapter dap;
        DataTable dt;
        SqlCommand com;

        public frmImports()
        {
            InitializeComponent();
            db.SystemConnection();
        }

        private void frmImports_Load(object sender, EventArgs e)
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

            dap = new SqlDataAdapter("SELECT * FROM fnGetAllSuppliers()", db.con);
            dt = new DataTable();
            dap.Fill(dt);

            cboSupplierName.DataSource = null;
            cboSupplierName.Items.Clear();

            cboSupplierName.DataSource = dt;
            cboSupplierName.DisplayMember = "Supplier";
            cboSupplierName.ValueMember = "SupID";

            cboSupplierName.Text = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboStaffID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtStaffName.Text = cboStaffID.SelectedValue.ToString();
        }

        private void cboSupplierName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtSupplierID.Text = cboSupplierName.SelectedValue.ToString();
        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {
            com = new SqlCommand("SELECT ProName FROM tb_Products WHERE ProCode ='" +txtProductCode.Text+"'",db.con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtProductName.Text = dr["ProName"].ToString();
                }
            }
            else
            {
                txtProductName.Text = null;
            }
            dr.Dispose();
            com.Dispose();
        }
    }
}
