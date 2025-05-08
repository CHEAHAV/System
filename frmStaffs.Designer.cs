namespace Systems
{
    partial class frmStaffs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffs));
            this.btnSearchStaff = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.btnViewStaff = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnStaffBrows = new System.Windows.Forms.Button();
            this.picStaff = new System.Windows.Forms.PictureBox();
            this.cmbStaffPosition = new System.Windows.Forms.ComboBox();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.ckbStopwork = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExitStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.txtStaffFullName = new System.Windows.Forms.TextBox();
            this.txtStaffSalary = new System.Windows.Forms.TextBox();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchStaff.Image")));
            this.btnSearchStaff.Location = new System.Drawing.Point(721, 361);
            this.btnSearchStaff.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Size = new System.Drawing.Size(68, 56);
            this.btnSearchStaff.TabIndex = 59;
            this.btnSearchStaff.UseVisualStyleBackColor = true;
            this.btnSearchStaff.Click += new System.EventHandler(this.btnSearchStaff_Click);
            // 
            // dgvStaff
            // 
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(19, 520);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.Size = new System.Drawing.Size(770, 224);
            this.dgvStaff.TabIndex = 58;
            // 
            // btnViewStaff
            // 
            this.btnViewStaff.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnViewStaff.Image")));
            this.btnViewStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewStaff.Location = new System.Drawing.Point(639, 442);
            this.btnViewStaff.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnViewStaff.Name = "btnViewStaff";
            this.btnViewStaff.Size = new System.Drawing.Size(150, 66);
            this.btnViewStaff.TabIndex = 57;
            this.btnViewStaff.Text = "View";
            this.btnViewStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewStaff.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateStaff.Image")));
            this.btnUpdateStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateStaff.Location = new System.Drawing.Point(436, 442);
            this.btnUpdateStaff.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(150, 66);
            this.btnUpdateStaff.TabIndex = 56;
            this.btnUpdateStaff.Text = "Update";
            this.btnUpdateStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateStaff.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteStaff.Image")));
            this.btnDeleteStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteStaff.Location = new System.Drawing.Point(228, 442);
            this.btnDeleteStaff.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(150, 66);
            this.btnDeleteStaff.TabIndex = 55;
            this.btnDeleteStaff.Text = "Delete";
            this.btnDeleteStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            // 
            // btnStaffBrows
            // 
            this.btnStaffBrows.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffBrows.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffBrows.Image")));
            this.btnStaffBrows.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffBrows.Location = new System.Drawing.Point(631, 267);
            this.btnStaffBrows.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnStaffBrows.Name = "btnStaffBrows";
            this.btnStaffBrows.Size = new System.Drawing.Size(158, 66);
            this.btnStaffBrows.TabIndex = 53;
            this.btnStaffBrows.Text = "Brows";
            this.btnStaffBrows.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStaffBrows.UseVisualStyleBackColor = true;
            this.btnStaffBrows.Click += new System.EventHandler(this.btnStaffBrows_Click);
            // 
            // picStaff
            // 
            this.picStaff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picStaff.Location = new System.Drawing.Point(631, 57);
            this.picStaff.Name = "picStaff";
            this.picStaff.Size = new System.Drawing.Size(158, 198);
            this.picStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStaff.TabIndex = 51;
            this.picStaff.TabStop = false;
            this.picStaff.Tag = "Photos";
            // 
            // cmbStaffPosition
            // 
            this.cmbStaffPosition.FormattingEnabled = true;
            this.cmbStaffPosition.Items.AddRange(new object[] {
            "Accountant",
            "Cashier",
            "Designer",
            "Driver",
            "Programmer",
            "Receptionist",
            "Stock Keeper"});
            this.cmbStaffPosition.Location = new System.Drawing.Point(260, 283);
            this.cmbStaffPosition.Name = "cmbStaffPosition";
            this.cmbStaffPosition.Size = new System.Drawing.Size(224, 32);
            this.cmbStaffPosition.TabIndex = 50;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(389, 177);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(81, 28);
            this.radFemale.TabIndex = 48;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(262, 178);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(62, 28);
            this.radMale.TabIndex = 47;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // ckbStopwork
            // 
            this.ckbStopwork.AutoSize = true;
            this.ckbStopwork.Location = new System.Drawing.Point(262, 403);
            this.ckbStopwork.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ckbStopwork.Name = "ckbStopwork";
            this.ckbStopwork.Size = new System.Drawing.Size(15, 14);
            this.ckbStopwork.TabIndex = 46;
            this.ckbStopwork.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("CollegiateFLF", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 37);
            this.label2.TabIndex = 45;
            this.label2.Text = "Staff Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExitStaff
            // 
            this.btnExitStaff.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnExitStaff.Image")));
            this.btnExitStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitStaff.Location = new System.Drawing.Point(753, 913);
            this.btnExitStaff.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnExitStaff.Name = "btnExitStaff";
            this.btnExitStaff.Size = new System.Drawing.Size(150, 66);
            this.btnExitStaff.TabIndex = 44;
            this.btnExitStaff.Text = "Exit";
            this.btnExitStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExitStaff.UseVisualStyleBackColor = true;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStaff.Image")));
            this.btnAddStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStaff.Location = new System.Drawing.Point(18, 442);
            this.btnAddStaff.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(150, 66);
            this.btnAddStaff.TabIndex = 43;
            this.btnAddStaff.Text = "ADD";
            this.btnAddStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // txtStaffFullName
            // 
            this.txtStaffFullName.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffFullName.Location = new System.Drawing.Point(260, 112);
            this.txtStaffFullName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtStaffFullName.Multiline = true;
            this.txtStaffFullName.Name = "txtStaffFullName";
            this.txtStaffFullName.Size = new System.Drawing.Size(212, 44);
            this.txtStaffFullName.TabIndex = 42;
            // 
            // txtStaffSalary
            // 
            this.txtStaffSalary.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffSalary.Location = new System.Drawing.Point(260, 337);
            this.txtStaffSalary.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtStaffSalary.Multiline = true;
            this.txtStaffSalary.Name = "txtStaffSalary";
            this.txtStaffSalary.Size = new System.Drawing.Size(131, 42);
            this.txtStaffSalary.TabIndex = 41;
            // 
            // txtStaffId
            // 
            this.txtStaffId.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffId.Location = new System.Drawing.Point(262, 57);
            this.txtStaffId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtStaffId.Multiline = true;
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(66, 42);
            this.txtStaffId.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 124);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 25);
            this.label8.TabIndex = 39;
            this.label8.Text = "Full Name : ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 177);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 38;
            this.label7.Text = "Gender : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Dat of Birth : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Position : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 340);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Salary : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 396);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Stop Work : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Id : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpdob
            // 
            this.dtpdob.CustomFormat = "yyyy-MM-dd";
            this.dtpdob.Location = new System.Drawing.Point(262, 229);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(260, 31);
            this.dtpdob.TabIndex = 61;
            this.dtpdob.Value = new System.DateTime(2025, 5, 5, 0, 0, 0, 0);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(639, 751);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 66);
            this.btnExit.TabIndex = 78;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(564, 361);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(165, 56);
            this.txtSearch.TabIndex = 60;
            // 
            // frmStaffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 830);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dtpdob);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearchStaff);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.btnViewStaff);
            this.Controls.Add(this.btnUpdateStaff);
            this.Controls.Add(this.btnDeleteStaff);
            this.Controls.Add(this.btnStaffBrows);
            this.Controls.Add(this.picStaff);
            this.Controls.Add(this.cmbStaffPosition);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.ckbStopwork);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExitStaff);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.txtStaffFullName);
            this.Controls.Add(this.txtStaffSalary);
            this.Controls.Add(this.txtStaffId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmStaffs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staffs";
            this.Load += new System.EventHandler(this.frmStaffs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchStaff;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Button btnViewStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnStaffBrows;
        private System.Windows.Forms.PictureBox picStaff;
        private System.Windows.Forms.ComboBox cmbStaffPosition;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.CheckBox ckbStopwork;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExitStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.TextBox txtStaffFullName;
        private System.Windows.Forms.TextBox txtStaffSalary;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSearch;
    }
}