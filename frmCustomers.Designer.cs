namespace Systems
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.btnViewCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnExitCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtCustomerContact = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCustomer.Image")));
            this.btnSearchCustomer.Location = new System.Drawing.Point(440, 393);
            this.btnSearchCustomer.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(63, 65);
            this.btnSearchCustomer.TabIndex = 52;
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(12, 467);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.Size = new System.Drawing.Size(508, 265);
            this.dgvCustomer.TabIndex = 50;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            // 
            // btnViewCustomer
            // 
            this.btnViewCustomer.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnViewCustomer.Image")));
            this.btnViewCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCustomer.Location = new System.Drawing.Point(12, 386);
            this.btnViewCustomer.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnViewCustomer.Name = "btnViewCustomer";
            this.btnViewCustomer.Size = new System.Drawing.Size(150, 65);
            this.btnViewCustomer.TabIndex = 49;
            this.btnViewCustomer.Text = "View";
            this.btnViewCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewCustomer.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateCustomer.Image")));
            this.btnUpdateCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(191, 295);
            this.btnUpdateCustomer.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(150, 65);
            this.btnUpdateCustomer.TabIndex = 48;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCustomer.Image")));
            this.btnDeleteCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(370, 295);
            this.btnDeleteCustomer.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(150, 65);
            this.btnDeleteCustomer.TabIndex = 47;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnExitCustomer
            // 
            this.btnExitCustomer.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitCustomer.Image = global::Systems.Properties.Resources.Cancel;
            this.btnExitCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitCustomer.Location = new System.Drawing.Point(370, 744);
            this.btnExitCustomer.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnExitCustomer.Name = "btnExitCustomer";
            this.btnExitCustomer.Size = new System.Drawing.Size(150, 65);
            this.btnExitCustomer.TabIndex = 46;
            this.btnExitCustomer.Text = "Exit";
            this.btnExitCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExitCustomer.UseVisualStyleBackColor = true;
            this.btnExitCustomer.Click += new System.EventHandler(this.btnExitCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.Image")));
            this.btnAddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCustomer.Location = new System.Drawing.Point(12, 295);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(150, 65);
            this.btnAddCustomer.TabIndex = 45;
            this.btnAddCustomer.Text = "ADD";
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtCustomerContact
            // 
            this.txtCustomerContact.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerContact.Location = new System.Drawing.Point(169, 226);
            this.txtCustomerContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerContact.Multiline = true;
            this.txtCustomerContact.Name = "txtCustomerContact";
            this.txtCustomerContact.Size = new System.Drawing.Size(188, 42);
            this.txtCustomerContact.TabIndex = 44;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Khmer OS Battambang", 15.75F);
            this.txtCustomerName.Location = new System.Drawing.Point(169, 136);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(188, 42);
            this.txtCustomerName.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "Contact : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "Name : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("CollegiateFLF", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 37);
            this.label2.TabIndex = 40;
            this.label2.Text = "Customer Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCusID
            // 
            this.txtCusID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCusID.Font = new System.Drawing.Font("Khmer OS Battambang", 15.75F);
            this.txtCusID.Location = new System.Drawing.Point(169, 68);
            this.txtCusID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCusID.Multiline = true;
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.ReadOnly = true;
            this.txtCusID.Size = new System.Drawing.Size(75, 42);
            this.txtCusID.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "ID : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(241, 396);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 57);
            this.txtSearch.TabIndex = 55;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 816);
            this.ControlBox = false;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtCusID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.btnViewCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnExitCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.txtCustomerContact);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnViewCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnExitCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtCustomerContact;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

