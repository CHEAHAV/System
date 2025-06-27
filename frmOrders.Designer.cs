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
            this.dateOrders = new System.Windows.Forms.DateTimePicker();
            this.txtOrdersCustomerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStaffID = new System.Windows.Forms.ComboBox();
            this.cboCusID = new System.Windows.Forms.ComboBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lisOrders = new System.Windows.Forms.ListView();
            this.cboProductName = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnExitOrder = new System.Windows.Forms.Button();
            this.btnAddOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateOrders
            // 
            this.dateOrders.Location = new System.Drawing.Point(238, 106);
            this.dateOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateOrders.Name = "dateOrders";
            this.dateOrders.Size = new System.Drawing.Size(238, 31);
            this.dateOrders.TabIndex = 90;
            // 
            // txtOrdersCustomerName
            // 
            this.txtOrdersCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtOrdersCustomerName.Font = new System.Drawing.Font("Khmer OS Battambang", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdersCustomerName.Location = new System.Drawing.Point(670, 255);
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
            this.label6.Location = new System.Drawing.Point(420, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 25);
            this.label6.TabIndex = 88;
            this.label6.Text = "Customer Name : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStaffName
            // 
            this.txtStaffName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtStaffName.Font = new System.Drawing.Font("Khmer OS Battambang", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(670, 176);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStaffName.Multiline = true;
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.ReadOnly = true;
            this.txtStaffName.Size = new System.Drawing.Size(170, 42);
            this.txtStaffName.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(408, 185);
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
            this.label3.Location = new System.Drawing.Point(88, 183);
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
            this.label4.Location = new System.Drawing.Point(32, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 81;
            this.label4.Text = "Date of Order : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("CollegiateFLF", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(868, 88);
            this.label2.TabIndex = 80;
            this.label2.Text = "Order Products";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtOrderTotal.Font = new System.Drawing.Font("Khmer OS Battambang", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderTotal.Location = new System.Drawing.Point(460, 765);
            this.txtOrderTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderTotal.Multiline = true;
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(155, 42);
            this.txtOrderTotal.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(364, 768);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 99;
            this.label7.Text = "Total : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 101;
            this.label1.Text = "Customer ID : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboStaffID
            // 
            this.cboStaffID.Font = new System.Drawing.Font("Khmer OS Battambang", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStaffID.FormattingEnabled = true;
            this.cboStaffID.Location = new System.Drawing.Point(238, 176);
            this.cboStaffID.Name = "cboStaffID";
            this.cboStaffID.Size = new System.Drawing.Size(121, 42);
            this.cboStaffID.TabIndex = 1;
            this.cboStaffID.SelectionChangeCommitted += new System.EventHandler(this.cboStaffID_SelectionChangeCommitted);
            // 
            // cboCusID
            // 
            this.cboCusID.Font = new System.Drawing.Font("Khmer OS Battambang", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCusID.FormattingEnabled = true;
            this.cboCusID.Location = new System.Drawing.Point(238, 255);
            this.cboCusID.Name = "cboCusID";
            this.cboCusID.Size = new System.Drawing.Size(121, 42);
            this.cboCusID.TabIndex = 102;
            this.cboCusID.SelectionChangeCommitted += new System.EventHandler(this.cboCusID_SelectionChangeCommitted);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUnitPrice.Location = new System.Drawing.Point(670, 405);
            this.txtUnitPrice.Multiline = true;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(170, 42);
            this.txtUnitPrice.TabIndex = 129;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(238, 399);
            this.txtQty.Multiline = true;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(121, 42);
            this.txtQty.TabIndex = 128;
            // 
            // txtProductCode
            // 
            this.txtProductCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtProductCode.Location = new System.Drawing.Point(238, 326);
            this.txtProductCode.Multiline = true;
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.ReadOnly = true;
            this.txtProductCode.Size = new System.Drawing.Size(121, 42);
            this.txtProductCode.TabIndex = 126;
            this.txtProductCode.TextChanged += new System.EventHandler(this.txtProductCode_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(480, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 25);
            this.label9.TabIndex = 125;
            this.label9.Text = "Unit Price : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(78, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 25);
            this.label10.TabIndex = 124;
            this.label10.Text = "Quantity : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(426, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 25);
            this.label8.TabIndex = 123;
            this.label8.Text = "Product\'s Name : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 25);
            this.label11.TabIndex = 122;
            this.label11.Text = "Product\'s Code : ";
            // 
            // lisOrders
            // 
            this.lisOrders.Font = new System.Drawing.Font("Khmer OS Battambang", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisOrders.HideSelection = false;
            this.lisOrders.Location = new System.Drawing.Point(25, 549);
            this.lisOrders.Name = "lisOrders";
            this.lisOrders.Size = new System.Drawing.Size(815, 201);
            this.lisOrders.TabIndex = 130;
            this.lisOrders.UseCompatibleStateImageBehavior = false;
            // 
            // cboProductName
            // 
            this.cboProductName.Font = new System.Drawing.Font("Khmer OS Battambang", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProductName.FormattingEnabled = true;
            this.cboProductName.Location = new System.Drawing.Point(670, 326);
            this.cboProductName.Name = "cboProductName";
            this.cboProductName.Size = new System.Drawing.Size(170, 42);
            this.cboProductName.TabIndex = 132;
            this.cboProductName.SelectionChangeCommitted += new System.EventHandler(this.cboProductName_SelectionChangeCommitted);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(25, 480);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(815, 65);
            this.label12.TabIndex = 133;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Aqua;
            this.btnSave.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(692, 485);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 55);
            this.btnSave.TabIndex = 131;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnViewOrders.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnViewOrders.Image")));
            this.btnViewOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewOrders.Location = new System.Drawing.Point(37, 485);
            this.btnViewOrders.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(135, 55);
            this.btnViewOrders.TabIndex = 95;
            this.btnViewOrders.Text = "View";
            this.btnViewOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewOrders.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemove.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(253, 485);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(155, 55);
            this.btnRemove.TabIndex = 93;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnExitOrder
            // 
            this.btnExitOrder.BackColor = System.Drawing.Color.Red;
            this.btnExitOrder.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnExitOrder.Image")));
            this.btnExitOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitOrder.Location = new System.Drawing.Point(705, 759);
            this.btnExitOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExitOrder.Name = "btnExitOrder";
            this.btnExitOrder.Size = new System.Drawing.Size(135, 55);
            this.btnExitOrder.TabIndex = 92;
            this.btnExitOrder.Text = "Exit";
            this.btnExitOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExitOrder.UseVisualStyleBackColor = false;
            this.btnExitOrder.Click += new System.EventHandler(this.btnExitOrder_Click);
            // 
            // btnAddOrders
            // 
            this.btnAddOrders.BackColor = System.Drawing.Color.Silver;
            this.btnAddOrders.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnAddOrders.Image")));
            this.btnAddOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddOrders.Location = new System.Drawing.Point(483, 485);
            this.btnAddOrders.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddOrders.Name = "btnAddOrders";
            this.btnAddOrders.Size = new System.Drawing.Size(135, 55);
            this.btnAddOrders.TabIndex = 91;
            this.btnAddOrders.Text = "ADD";
            this.btnAddOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddOrders.UseVisualStyleBackColor = false;
            this.btnAddOrders.Click += new System.EventHandler(this.btnAddOrders_Click);
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 835);
            this.ControlBox = false;
            this.Controls.Add(this.cboProductName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lisOrders);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboCusID);
            this.Controls.Add(this.cboStaffID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrderTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnExitOrder);
            this.Controls.Add(this.btnAddOrders);
            this.Controls.Add(this.dateOrders);
            this.Controls.Add(this.txtOrdersCustomerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrders";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnExitOrder;
        private System.Windows.Forms.Button btnAddOrders;
        private System.Windows.Forms.DateTimePicker dateOrders;
        private System.Windows.Forms.TextBox txtOrdersCustomerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStaffID;
        private System.Windows.Forms.ComboBox cboCusID;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView lisOrders;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboProductName;
        private System.Windows.Forms.Label label12;
    }
}