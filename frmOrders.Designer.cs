namespace Systems
{
    partial class frmOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrders));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.dateOrders = new System.Windows.Forms.DateTimePicker();
            this.txtOrdersCustomerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrdersStaffName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearchOrders = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnUpdateOrders = new System.Windows.Forms.Button();
            this.btnDeleteOrders = new System.Windows.Forms.Button();
            this.btnExitOrder = new System.Windows.Forms.Button();
            this.btnAddOrders = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStaffID = new System.Windows.Forms.ComboBox();
            this.cboCusID = new System.Windows.Forms.ComboBox();
            this.txtOrdersCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Khmer OS Battambang", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearch.Location = new System.Drawing.Point(411, 420);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(218, 59);
            this.txtSearch.TabIndex = 97;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(34, 493);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowTemplate.Height = 30;
            this.dgvOrders.Size = new System.Drawing.Size(594, 265);
            this.dgvOrders.TabIndex = 96;
            this.dgvOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellClick);
            // 
            // dateOrders
            // 
            this.dateOrders.Location = new System.Drawing.Point(230, 133);
            this.dateOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateOrders.Name = "dateOrders";
            this.dateOrders.Size = new System.Drawing.Size(238, 31);
            this.dateOrders.TabIndex = 90;
            // 
            // txtOrdersCustomerName
            // 
            this.txtOrdersCustomerName.Font = new System.Drawing.Font("Khmer OS Battambang", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdersCustomerName.Location = new System.Drawing.Point(230, 378);
            this.txtOrdersCustomerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrdersCustomerName.Multiline = true;
            this.txtOrdersCustomerName.Name = "txtOrdersCustomerName";
            this.txtOrdersCustomerName.ReadOnly = true;
            this.txtOrdersCustomerName.Size = new System.Drawing.Size(170, 42);
            this.txtOrdersCustomerName.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 25);
            this.label6.TabIndex = 88;
            this.label6.Text = "Customer Name : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrdersStaffName
            // 
            this.txtOrdersStaffName.Font = new System.Drawing.Font("Khmer OS Battambang", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdersStaffName.Location = new System.Drawing.Point(230, 258);
            this.txtOrdersStaffName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrdersStaffName.Multiline = true;
            this.txtOrdersStaffName.Name = "txtOrdersStaffName";
            this.txtOrdersStaffName.ReadOnly = true;
            this.txtOrdersStaffName.Size = new System.Drawing.Size(170, 42);
            this.txtOrdersStaffName.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 25);
            this.label5.TabIndex = 84;
            this.label5.Text = "Staff\'s Full Name : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 82;
            this.label3.Text = "Staff ID : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 81;
            this.label4.Text = "Date of Order : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("CollegiateFLF", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 37);
            this.label2.TabIndex = 80;
            this.label2.Text = "Orders";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderTotal.Location = new System.Drawing.Point(230, 443);
            this.txtOrderTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderTotal.Multiline = true;
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(119, 42);
            this.txtOrderTotal.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 99;
            this.label7.Text = "Total : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearchOrders
            // 
            this.btnSearchOrders.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchOrders.Image")));
            this.btnSearchOrders.Location = new System.Drawing.Point(563, 418);
            this.btnSearchOrders.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearchOrders.Name = "btnSearchOrders";
            this.btnSearchOrders.Size = new System.Drawing.Size(66, 66);
            this.btnSearchOrders.TabIndex = 98;
            this.btnSearchOrders.UseVisualStyleBackColor = true;
            this.btnSearchOrders.Click += new System.EventHandler(this.btnSearchOrders_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnViewOrders.Image")));
            this.btnViewOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewOrders.Location = new System.Drawing.Point(34, 768);
            this.btnViewOrders.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(135, 66);
            this.btnViewOrders.TabIndex = 95;
            this.btnViewOrders.Text = "View";
            this.btnViewOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewOrders.UseVisualStyleBackColor = true;
            // 
            // btnUpdateOrders
            // 
            this.btnUpdateOrders.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateOrders.Image")));
            this.btnUpdateOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateOrders.Location = new System.Drawing.Point(483, 191);
            this.btnUpdateOrders.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdateOrders.Name = "btnUpdateOrders";
            this.btnUpdateOrders.Size = new System.Drawing.Size(145, 66);
            this.btnUpdateOrders.TabIndex = 94;
            this.btnUpdateOrders.Text = "Update";
            this.btnUpdateOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateOrders.UseVisualStyleBackColor = true;
            this.btnUpdateOrders.Click += new System.EventHandler(this.btnUpdateOrders_Click);
            // 
            // btnDeleteOrders
            // 
            this.btnDeleteOrders.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteOrders.Image")));
            this.btnDeleteOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteOrders.Location = new System.Drawing.Point(493, 307);
            this.btnDeleteOrders.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteOrders.Name = "btnDeleteOrders";
            this.btnDeleteOrders.Size = new System.Drawing.Size(135, 66);
            this.btnDeleteOrders.TabIndex = 93;
            this.btnDeleteOrders.Text = "Delete";
            this.btnDeleteOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteOrders.UseVisualStyleBackColor = true;
            // 
            // btnExitOrder
            // 
            this.btnExitOrder.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnExitOrder.Image")));
            this.btnExitOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitOrder.Location = new System.Drawing.Point(494, 768);
            this.btnExitOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExitOrder.Name = "btnExitOrder";
            this.btnExitOrder.Size = new System.Drawing.Size(135, 66);
            this.btnExitOrder.TabIndex = 92;
            this.btnExitOrder.Text = "Exit";
            this.btnExitOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExitOrder.UseVisualStyleBackColor = true;
            this.btnExitOrder.Click += new System.EventHandler(this.btnExitOrder_Click);
            // 
            // btnAddOrders
            // 
            this.btnAddOrders.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnAddOrders.Image")));
            this.btnAddOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddOrders.Location = new System.Drawing.Point(493, 74);
            this.btnAddOrders.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddOrders.Name = "btnAddOrders";
            this.btnAddOrders.Size = new System.Drawing.Size(135, 66);
            this.btnAddOrders.TabIndex = 91;
            this.btnAddOrders.Text = "ADD";
            this.btnAddOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddOrders.UseVisualStyleBackColor = true;
            this.btnAddOrders.Click += new System.EventHandler(this.btnAddOrders_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 101;
            this.label1.Text = "Customer ID : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboStaffID
            // 
            this.cboStaffID.FormattingEnabled = true;
            this.cboStaffID.Location = new System.Drawing.Point(230, 194);
            this.cboStaffID.Name = "cboStaffID";
            this.cboStaffID.Size = new System.Drawing.Size(121, 32);
            this.cboStaffID.TabIndex = 1;
            this.cboStaffID.SelectionChangeCommitted += new System.EventHandler(this.cboStaffID_SelectionChangeCommitted);
            // 
            // cboCusID
            // 
            this.cboCusID.FormattingEnabled = true;
            this.cboCusID.Location = new System.Drawing.Point(228, 326);
            this.cboCusID.Name = "cboCusID";
            this.cboCusID.Size = new System.Drawing.Size(121, 32);
            this.cboCusID.TabIndex = 102;
            this.cboCusID.SelectionChangeCommitted += new System.EventHandler(this.cboCusID_SelectionChangeCommitted);
            // 
            // txtOrdersCode
            // 
            this.txtOrdersCode.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdersCode.Location = new System.Drawing.Point(232, 62);
            this.txtOrdersCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrdersCode.Multiline = true;
            this.txtOrdersCode.Name = "txtOrdersCode";
            this.txtOrdersCode.ReadOnly = true;
            this.txtOrdersCode.Size = new System.Drawing.Size(100, 42);
            this.txtOrdersCode.TabIndex = 104;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(128, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 103;
            this.label8.Text = "Code : ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 852);
            this.ControlBox = false;
            this.Controls.Add(this.txtOrdersCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboCusID);
            this.Controls.Add(this.cboStaffID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrderTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSearchOrders);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnUpdateOrders);
            this.Controls.Add(this.btnDeleteOrders);
            this.Controls.Add(this.btnExitOrder);
            this.Controls.Add(this.btnAddOrders);
            this.Controls.Add(this.dateOrders);
            this.Controls.Add(this.txtOrdersCustomerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOrdersStaffName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrders";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchOrders;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnUpdateOrders;
        private System.Windows.Forms.Button btnDeleteOrders;
        private System.Windows.Forms.Button btnExitOrder;
        private System.Windows.Forms.Button btnAddOrders;
        private System.Windows.Forms.DateTimePicker dateOrders;
        private System.Windows.Forms.TextBox txtOrdersCustomerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrdersStaffName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStaffID;
        private System.Windows.Forms.ComboBox cboCusID;
        private System.Windows.Forms.TextBox txtOrdersCode;
        private System.Windows.Forms.Label label8;
    }
}