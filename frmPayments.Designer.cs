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
            this.btnViewPayment = new System.Windows.Forms.Button();
            this.btnExitPayment = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.datePayment = new System.Windows.Forms.DateTimePicker();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtPaymentStaffName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboInvoiceCode = new System.Windows.Forms.ComboBox();
            this.cboStaffID = new System.Windows.Forms.ComboBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.txtRemain = new System.Windows.Forms.TextBox();
            this.lblRemain = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnViewPayment
            // 
            this.btnViewPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnViewPayment.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnViewPayment.Image")));
            this.btnViewPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewPayment.Location = new System.Drawing.Point(213, 474);
            this.btnViewPayment.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnViewPayment.Name = "btnViewPayment";
            this.btnViewPayment.Size = new System.Drawing.Size(150, 55);
            this.btnViewPayment.TabIndex = 76;
            this.btnViewPayment.Text = "View";
            this.btnViewPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewPayment.UseVisualStyleBackColor = false;
            // 
            // btnExitPayment
            // 
            this.btnExitPayment.BackColor = System.Drawing.Color.Red;
            this.btnExitPayment.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnExitPayment.Image")));
            this.btnExitPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitPayment.Location = new System.Drawing.Point(389, 474);
            this.btnExitPayment.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnExitPayment.Name = "btnExitPayment";
            this.btnExitPayment.Size = new System.Drawing.Size(150, 55);
            this.btnExitPayment.TabIndex = 73;
            this.btnExitPayment.Text = "Exit";
            this.btnExitPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExitPayment.UseVisualStyleBackColor = false;
            this.btnExitPayment.Click += new System.EventHandler(this.btnExitPayment_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPayment.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnPayment.Image")));
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(22, 474);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(165, 55);
            this.btnPayment.TabIndex = 72;
            this.btnPayment.Text = "Payment";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // datePayment
            // 
            this.datePayment.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePayment.Location = new System.Drawing.Point(250, 105);
            this.datePayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datePayment.Name = "datePayment";
            this.datePayment.Size = new System.Drawing.Size(188, 31);
            this.datePayment.TabIndex = 71;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTotal.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(25, 403);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(162, 42);
            this.txtTotal.TabIndex = 70;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(73, 372);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 25);
            this.lblTotal.TabIndex = 69;
            this.lblTotal.Text = "Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPaymentStaffName
            // 
            this.txtPaymentStaffName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPaymentStaffName.Font = new System.Drawing.Font("Khmer OS Battambang", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentStaffName.Location = new System.Drawing.Point(250, 227);
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
            this.label1.Location = new System.Drawing.Point(67, 301);
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
            this.label5.Location = new System.Drawing.Point(20, 235);
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
            this.label3.Location = new System.Drawing.Point(115, 172);
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
            this.label4.Location = new System.Drawing.Point(28, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 25);
            this.label4.TabIndex = 62;
            this.label4.Text = "Date of Payment : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("CollegiateFLF", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(535, 72);
            this.label2.TabIndex = 61;
            this.label2.Text = "Payments";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboInvoiceCode
            // 
            this.cboInvoiceCode.Font = new System.Drawing.Font("Khmer OS Battambang", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInvoiceCode.FormattingEnabled = true;
            this.cboInvoiceCode.Location = new System.Drawing.Point(250, 295);
            this.cboInvoiceCode.Name = "cboInvoiceCode";
            this.cboInvoiceCode.Size = new System.Drawing.Size(94, 42);
            this.cboInvoiceCode.TabIndex = 1;
            this.cboInvoiceCode.SelectionChangeCommitted += new System.EventHandler(this.cboInvoiceCode_SelectionChangeCommitted);
            // 
            // cboStaffID
            // 
            this.cboStaffID.Font = new System.Drawing.Font("Khmer OS Battambang", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStaffID.FormattingEnabled = true;
            this.cboStaffID.Location = new System.Drawing.Point(250, 166);
            this.cboStaffID.Name = "cboStaffID";
            this.cboStaffID.Size = new System.Drawing.Size(94, 42);
            this.cboStaffID.TabIndex = 1;
            this.cboStaffID.SelectionChangeCommitted += new System.EventHandler(this.cboStaffID_SelectionChangeCommitted);
            // 
            // txtDeposit
            // 
            this.txtDeposit.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposit.Location = new System.Drawing.Point(215, 403);
            this.txtDeposit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeposit.Multiline = true;
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(150, 42);
            this.txtDeposit.TabIndex = 85;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.Location = new System.Drawing.Point(245, 371);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(87, 25);
            this.lblDeposit.TabIndex = 84;
            this.lblDeposit.Text = "Deposit";
            this.lblDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRemain
            // 
            this.txtRemain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRemain.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemain.Location = new System.Drawing.Point(389, 403);
            this.txtRemain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemain.Multiline = true;
            this.txtRemain.Name = "txtRemain";
            this.txtRemain.ReadOnly = true;
            this.txtRemain.Size = new System.Drawing.Size(150, 42);
            this.txtRemain.TabIndex = 87;
            // 
            // lblRemain
            // 
            this.lblRemain.AutoSize = true;
            this.lblRemain.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemain.Location = new System.Drawing.Point(420, 367);
            this.lblRemain.Name = "lblRemain";
            this.lblRemain.Size = new System.Drawing.Size(89, 25);
            this.lblRemain.TabIndex = 86;
            this.lblRemain.Text = "Remain";
            this.lblRemain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(14, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(533, 69);
            this.label6.TabIndex = 88;
            // 
            // frmPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 546);
            this.ControlBox = false;
            this.Controls.Add(this.txtRemain);
            this.Controls.Add(this.lblRemain);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.cboStaffID);
            this.Controls.Add(this.cboInvoiceCode);
            this.Controls.Add(this.btnViewPayment);
            this.Controls.Add(this.btnExitPayment);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.datePayment);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtPaymentStaffName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmPayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.frmPayments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnViewPayment;
        private System.Windows.Forms.Button btnExitPayment;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.DateTimePicker datePayment;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtPaymentStaffName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboInvoiceCode;
        private System.Windows.Forms.ComboBox cboStaffID;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox txtRemain;
        private System.Windows.Forms.Label lblRemain;
        private System.Windows.Forms.Label label6;
    }
}