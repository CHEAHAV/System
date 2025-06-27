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
    public partial class frmRegister : Form
    {
        Database db = new Database();
        SqlCommand com;
        SqlDependency dep;
        SqlDataAdapter dap;
        public frmRegister()
        {
            InitializeComponent();
            db.SystemConnection();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("spSetRegister", db.con);
            com.CommandType = CommandType.StoredProcedure; 
            com.Parameters.AddWithValue("@u", txtUsername.Text);
            com.Parameters.AddWithValue("@g", txtGmail.Text);
            com.Parameters.AddWithValue("@p", txtPassword.Text);
            com.ExecuteNonQuery();
            MessageBox.Show("Success...!");

            txtUsername.Text = null;
            txtGmail.Text = null;
            txtPassword.Text = null;

            this.Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = ckbShowPassword.Checked ? '\0' : '*';
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
