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
using System.IO;
using System.Globalization;

namespace Systems
{
    public partial class frmStaffs : Form
    {
        Database db = new Database();
        SqlCommand com;
        SqlDependency dep;
        SqlDataAdapter dap;
        DataTable dt;

        string fp;
        byte[] photos;

        public frmStaffs()
        {
            InitializeComponent();
            db.SystemConnection();
            LoadData();
        }

        public void LoadData()
        { 
            dgvStaff.DataSource = null;
            com = new SqlCommand("spGetAllStaffs", db.con);
            com.CommandType = CommandType.StoredProcedure;

            dep = new SqlDependency(com);
            dep.OnChange += new OnChangeEventHandler(OnChange);

            dap = new SqlDataAdapter(com);
            dt = new DataTable();
            dap.Fill(dt);

            dgvStaff.DataSource = dt;
        }

        public void OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (this.InvokeRequired)
            { 
                dgvStaff.BeginInvoke(new MethodInvoker(LoadData));
            }
            else
            {
                LoadData();
            }
        }

        private void frmStaffs_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStaffBrows_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            fd.Title = "Select Staff Image";
            if (fd.ShowDialog() == DialogResult.OK)
            { 
                fp = fd.FileName;
                picStaff.Image = Image.FromFile(fp);
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            var Salary = Decimal.Parse(txtStaffSalary.Text,NumberStyles.Currency);
            com = new SqlCommand("spSetStaffs", db.con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@staffID", txtStaffId.Text);
            com.Parameters.AddWithValue("@FullName", txtStaffFullName.Text);

            if (radFemale.Checked == true)
            {
                com.Parameters.AddWithValue("@Gen", "F");
            }
            else
            {
                com.Parameters.AddWithValue("@Gen", "M");
            }

            com.Parameters.AddWithValue("@Dob", dtpdob.Value);
            com.Parameters.AddWithValue("@Position", cmbStaffPosition.Text);
            com.Parameters.AddWithValue("@Salary", Salary);
            com.Parameters.AddWithValue("@Stopwork", 0);

            if (fp != null)
            { 
                photos = File.ReadAllBytes(fp);
                com.Parameters.AddWithValue("@Photos", photos);
            }
            com.ExecuteNonQuery();
            fp = null;
            MessageBox.Show("Staff Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            (dgvStaff.DataSource as DataTable).DefaultView.RowFilter = string.Format("FullName LIKE '%{0}%' OR CONVERT(staffID, 'System.String') LIKE '%{0}%' OR (Gen LIKE '%{0}%')", txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
