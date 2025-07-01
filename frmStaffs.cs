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


            dgvStaff.ColumnHeadersDefaultCellStyle.Font = new Font("Century Schoolbook", 12, FontStyle.Bold);
            dgvStaff.DefaultCellStyle.Font = new Font("Khmer OS Battambang", 12, FontStyle.Regular);
            dgvStaff.Columns["staffID"].Width = 70;
            dgvStaff.Columns["FullName"].Width = 100;
            dgvStaff.Columns["Gen"].Width = 50;
            dgvStaff.Columns["Dob"].DefaultCellStyle.Format = "dd/MM/yyyy";

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dgvStaff.Columns["Photos"];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;

            //foreach (DataGridViewColumn col in dgvStaff.Columns)
            //{ 
            //    col.SortMode = DataGridViewColumnSortMode.NotSortable;
            //}
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPOS pos = new frmPOS();
            pos.Show();
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

            int i;
            if (dgvStaff.Rows.Count > 0 && dgvStaff.CurrentRow != null)
            {
                i = dgvStaff.CurrentRow.Index;

                DataGridViewRow row = dgvStaff.Rows[i];
                txtStaffId.Text = row.Cells["staffID"].Value.ToString();
                txtStaffFullName.Text = row.Cells["FullName"].Value.ToString();
                if (row.Cells["Gen"].Value.ToString() == "F")
                {
                    radFemale.Checked = true;
                }
                else
                {
                    radMale.Checked = true;
                }
                if (row.Cells["Dob"].Value != null && row.Cells["Dob"].Value != DBNull.Value)
                {
                    if (DateTime.TryParse(row.Cells["Dob"].Value.ToString(), out DateTime dob))
                    {
                        dtpdob.Value = dob;
                    }
                    else
                    {
                        MessageBox.Show("Invalid date format for DOB. Using current date.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dtpdob.Value = DateTime.Now; // Default to current date if parsing fails
                    }
                }
                else
                {
                    dtpdob.Value = DateTime.Now; // Default to current date if null
                }


                cmbStaffPosition.Text = row.Cells["Position"].Value.ToString();
                txtStaffSalary.Text = row.Cells["Salary"].Value.ToString();

                if (row.Cells["Photos"].Value != DBNull.Value)
                {
                    byte[] img = (byte[])row.Cells["Photos"].Value;
                    MemoryStream ms = new MemoryStream(img);
                    picStaff.Image = Image.FromStream(ms);
                }
                else
                {
                    picStaff.Image = null;
                }
                txtSearch.Text = null;
            }
            else
            {
                txtSearch.Text = null;
                txtStaffId.Clear();
                txtStaffFullName.Clear();
                radMale.Checked = false;
                radFemale.Checked = false;
                dtpdob.Value = DateTime.Now; // Default to current date if no data found
                cmbStaffPosition.SelectedIndex = -1; // Clear the selection
                txtStaffSalary.Clear();
                picStaff.Image = null; // Clear the image
                MessageBox.Show("No data found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            if (dgvStaff.RowCount > 0)
            {
                i = e.RowIndex;
                if (i < 0) return;

                DataGridViewRow row = dgvStaff.Rows[i];
                txtStaffId.Text = row.Cells["staffID"].Value.ToString();
                txtStaffFullName.Text = row.Cells["FullName"].Value.ToString();
                if (row.Cells["Gen"].Value.ToString() == "F")
                {
                    radFemale.Checked = true;
                }
                else
                {
                    radMale.Checked = true;
                }
                if (row.Cells["Dob"].Value != null && row.Cells["Dob"].Value != DBNull.Value)
                {
                    if (DateTime.TryParse(row.Cells["Dob"].Value.ToString(), out DateTime dob))
                    {
                        dtpdob.Value = dob;
                    }
                    else
                    {
                        MessageBox.Show("Invalid date format for DOB. Using current date.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dtpdob.Value = DateTime.Now; // Default to current date if parsing fails
                    }
                }
                else
                {
                    dtpdob.Value = DateTime.Now; // Default to current date if null
                }


                cmbStaffPosition.Text = row.Cells["Position"].Value.ToString();
                txtStaffSalary.Text = row.Cells["Salary"].Value.ToString();

                if (row.Cells["Photos"].Value != DBNull.Value)
                {
                    byte[] img = (byte[])row.Cells["Photos"].Value;
                    MemoryStream ms = new MemoryStream(img);
                    picStaff.Image = Image.FromStream(ms);
                }
                else
                {
                    picStaff.Image = null;
                }
            }
            else
            { 
                MessageBox.Show("No data available", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            var Salary = Decimal.Parse(txtStaffSalary.Text, NumberStyles.Currency);
            com = new SqlCommand("spUpdateStaffs", db.con);
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
            MessageBox.Show("Staff Update Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Do you want to delete it?", "Confirmation",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                com = new SqlCommand("spDeleteStaffs", db.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@staffID", txtStaffId.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("Staff Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }

        private void btnViewStaff_Click(object sender, EventArgs e)
        {

        }

        private void frmStaffs_Load(object sender, EventArgs e)
        {

        }
    }
}
