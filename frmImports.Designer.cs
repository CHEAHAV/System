namespace Systems
{
    partial class frmImports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImports));
            this.label2 = new System.Windows.Forms.Label();
            this.dgvImports = new System.Windows.Forms.DataGridView();
            this.btnExitImports = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImports)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("CollegiateFLF", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 37);
            this.label2.TabIndex = 79;
            this.label2.Text = "Imports";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvImports
            // 
            this.dgvImports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImports.Location = new System.Drawing.Point(5, 79);
            this.dgvImports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvImports.Name = "dgvImports";
            this.dgvImports.Size = new System.Drawing.Size(883, 364);
            this.dgvImports.TabIndex = 78;
            // 
            // btnExitImports
            // 
            this.btnExitImports.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitImports.Image = ((System.Drawing.Image)(resources.GetObject("btnExitImports.Image")));
            this.btnExitImports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitImports.Location = new System.Drawing.Point(753, 452);
            this.btnExitImports.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExitImports.Name = "btnExitImports";
            this.btnExitImports.Size = new System.Drawing.Size(135, 66);
            this.btnExitImports.TabIndex = 80;
            this.btnExitImports.Text = "Exit";
            this.btnExitImports.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExitImports.UseVisualStyleBackColor = true;
            this.btnExitImports.Click += new System.EventHandler(this.btnExitImports_Click);
            // 
            // frmImports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 533);
            this.ControlBox = false;
            this.Controls.Add(this.btnExitImports);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvImports);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmImports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmImports";
            this.Load += new System.EventHandler(this.frmImports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitImports;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvImports;
    }
}