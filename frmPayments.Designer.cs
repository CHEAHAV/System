namespace Systems
{
    partial class frmPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayments));
            this.btnSearchpayment = new System.Windows.Forms.Button();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.btnViewPayment = new System.Windows.Forms.Button();
            this.btnUpdatePayment = new System.Windows.Forms.Button();
            this.btnDeletePayment = new System.Windows.Forms.Button();
            this.btnExitPayment = new System.Windows.Forms.Button();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.datePayment = new System.Windows.Forms.DateTimePicker();
            this.txtpaymentAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPaymentStaffName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtPaymentCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboInvoiceCode = new System.Windows.Forms.ComboBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchpayment
            // 
            this.btnSearchpayment.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchpayment.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchpayment.Image")));
            this.btnSearchpayment.Location = new System.Drawing.Point(625, 434);
            this.btnSearchpayment.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSearchpayment.Name = "btnSearchpayment";
            this.btnSearchpayment.Size = new System.Drawing.Size(63, 66);
            this.btnSearchpayment.TabIndex = 79;
            this.btnSearchpayment.UseVisualStyleBackColor = true;
            this.btnSearchpayment.Click += new System.EventHandler(this.btnSearchpayment_Click);
            // 
            // dgvPayment
            // 
            this.dgvPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Location = new System.Drawing.Point(28, 510);
            this.dgvPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.Size = new System.Drawing.Size(660, 265);
            this.dgvPayment.TabIndex = 77;
            this.dgvPayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayment_CellClick);
            // 
            // btnViewPayment
            // 
            this.btnViewPayment.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnViewPayment.Image")));
            this.btnViewPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewPayment.Location = new System.Drawing.Point(28, 785);
            this.btnViewPayment.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnViewPayment.Name = "btnViewPayment";
            this.btnViewPayment.Size = new System.Drawing.Size(150, 66);
            this.btnViewPayment.TabIndex = 76;
            this.btnViewPayment.Text = "View";
            this.btnViewPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewPayment.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePayment
            // 
            this.btnUpdatePayment.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePayment.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdatePayment.Image")));
            this.btnUpdatePayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdatePayment.Location = new System.Drawing.Point(538, 208);
            this.btnUpdatePayment.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnUpdatePayment.Name = "btnUpdatePayment";
            this.btnUpdatePayment.Size = new System.Drawing.Size(150, 66);
            this.btnUpdatePayment.TabIndex = 75;
            this.btnUpdatePayment.Text = "Update";
            this.btnUpdatePayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdatePayment.UseVisualStyleBackColor = true;
            // 
            // btnDeletePayment
            // 
            this.btnDeletePayment.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePayment.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletePayment.Image")));
            this.btnDeletePayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePayment.Location = new System.Drawing.Point(538, 324);
            this.btnDeletePayment.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(150, 66);
            this.btnDeletePayment.TabIndex = 74;
            this.btnDeletePayment.Text = "Delete";
            this.btnDeletePayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletePayment.UseVisualStyleBackColor = true;
            // 
            // btnExitPayment
            // 
            this.btnExitPayment.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnExitPayment.Image")));
            this.btnExitPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitPayment.Location = new System.Drawing.Point(539, 785);
            this.btnExitPayment.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnExitPayment.Name = "btnExitPayment";
            this.btnExitPayment.Size = new System.Drawing.Size(150, 66);
            this.btnExitPayment.TabIndex = 73;
            this.btnExitPayment.Text = "Exit";
            this.btnExitPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExitPayment.UseVisualStyleBackColor = true;
            this.btnExitPayment.Click += new System.EventHandler(this.btnExitPayment_Click);
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPayment.Image")));
            this.btnAddPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPayment.Location = new System.Drawing.Point(538, 91);
            this.btnAddPayment.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(150, 66);
            this.btnAddPayment.TabIndex = 72;
            this.btnAddPayment.Text = "ADD";
            this.btnAddPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // datePayment
            // 
            this.datePayment.Location = new System.Drawing.Point(245, 167);
            this.datePayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datePayment.Name = "datePayment";
            this.datePayment.Size = new System.Drawing.Size(264, 31);
            this.datePayment.TabIndex = 71;
            // 
            // txtpaymentAmount
            // 
            this.txtpaymentAmount.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaymentAmount.Location = new System.Drawing.Point(245, 454);
            this.txtpaymentAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpaymentAmount.Multiline = true;
            this.txtpaymentAmount.Name = "txtpaymentAmount";
            this.txtpaymentAmount.ReadOnly = true;
            this.txtpaymentAmount.Size = new System.Drawing.Size(132, 42);
            this.txtpaymentAmount.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 25);
            this.label6.TabIndex = 69;
            this.label6.Text = "Payment Amount : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPaymentStaffName
            // 
            this.txtPaymentStaffName.Font = new System.Drawing.Font("Khmer OS Battambang", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentStaffName.Location = new System.Drawing.Point(245, 387);
            this.txtPaymentStaffName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPaymentStaffName.Multiline = true;
            this.txtPaymentStaffName.Name = "txtPaymentStaffName";
            this.txtPaymentStaffName.ReadOnly = true;
            this.txtPaymentStaffName.Size = new System.Drawing.Size(188, 42);
            this.txtPaymentStaffName.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 66;
            this.label1.Text = "Invoice Code : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 25);
            this.label5.TabIndex = 65;
            this.label5.Text = "Staff\'s Full Name : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 63;
            this.label3.Text = "Staff ID : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 25);
            this.label4.TabIndex = 62;
            this.label4.Text = "Date of Payment : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("CollegiateFLF", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 37);
            this.label2.TabIndex = 61;
            this.label2.Text = "Payments";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Khmer OS Battambang", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(438, 439);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(189, 55);
            this.txtSearch.TabIndex = 80;
            // 
            // txtPaymentCode
            // 
            this.txtPaymentCode.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentCode.Location = new System.Drawing.Point(245, 78);
            this.txtPaymentCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPaymentCode.Multiline = true;
            this.txtPaymentCode.Name = "txtPaymentCode";
            this.txtPaymentCode.ReadOnly = true;
            this.txtPaymentCode.Size = new System.Drawing.Size(70, 42);
            this.txtPaymentCode.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(139, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 81;
            this.label7.Text = "Code : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboInvoiceCode
            // 
            this.cboInvoiceCode.FormattingEnabled = true;
            this.cboInvoiceCode.Location = new System.Drawing.Point(245, 242);
            this.cboInvoiceCode.Name = "cboInvoiceCode";
            this.cboInvoiceCode.Size = new System.Drawing.Size(121, 32);
            this.cboInvoiceCode.TabIndex = 1;
            this.cboInvoiceCode.SelectionChangeCommitted += new System.EventHandler(this.cboInvoiceCode_SelectionChangeCommitted);
            this.cboInvoiceCode.TextChanged += new System.EventHandler(this.cboInvoiceCode_TextChanged);
            // 
            // txtStaffID
            // 
            this.txtStaffID.Font = new System.Drawing.Font("Khmer OS Battambang", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(245, 309);
            this.txtStaffID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStaffID.Multiline = true;
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.ReadOnly = true;
            this.txtStaffID.Size = new System.Drawing.Size(121, 42);
            this.txtStaffID.TabIndex = 85;
            // 
            // frmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 859);
            this.ControlBox = false;
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.cboInvoiceCode);
            this.Controls.Add(this.txtPaymentCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearchpayment);
            this.Controls.Add(this.dgvPayment);
            this.Controls.Add(this.btnViewPayment);
            this.Controls.Add(this.btnUpdatePayment);
            this.Controls.Add(this.btnDeletePayment);
            this.Controls.Add(this.btnExitPayment);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.datePayment);
            this.Controls.Add(this.txtpaymentAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPaymentStaffName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmPayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.frmPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchpayment;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.Button btnViewPayment;
        private System.Windows.Forms.Button btnUpdatePayment;
        private System.Windows.Forms.Button btnDeletePayment;
        private System.Windows.Forms.Button btnExitPayment;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.DateTimePicker datePayment;
        private System.Windows.Forms.TextBox txtpaymentAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPaymentStaffName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtPaymentCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboInvoiceCode;
        private System.Windows.Forms.TextBox txtStaffID;
    }
}