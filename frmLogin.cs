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
using static System.Collections.Specialized.BitVector32;

namespace Systems
{
    public partial class frmLogin : Form
    {
        Database db = new Database();
        SqlCommand com;
        SqlDependency dep;
        SqlDataAdapter dap;

        public object Session { get; private set; }

        public frmLogin()
        {
            InitializeComponent();
            db.SystemConnection();
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister register = new frmRegister();
            register.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string gmail = txtGmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            com = new SqlCommand("spLogin", db.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@g", gmail);
            com.Parameters.AddWithValue("@p", password);
            com.ExecuteNonQuery();

            int count = (int)com.ExecuteScalar();
            
            if (count > 0)
            {
                Session = gmail;
                this.Hide();
                frmPOS pos = new frmPOS();
                pos.Show();
                
            }
            else
            {
                MessageBox.Show("Gmail or Password is not correct", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = ckbShowPassword.Checked ? '\0' : '*';
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void llbForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
