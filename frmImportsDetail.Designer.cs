namespace Systems
{
    partial class frmImportsDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportsDetail));
            this.label2 = new System.Windows.Forms.Label();
            this.dgvImportsDetail = new System.Windows.Forms.DataGridView();
            this.btnExitImportsDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportsDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("CollegiateFLF", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 37);
            this.label2.TabIndex = 82;
            this.label2.Text = "Imports Detail";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvImportsDetail
            // 
            this.dgvImportsDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImportsDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportsDetail.Location = new System.Drawing.Point(4, 76);
            this.dgvImportsDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvImportsDetail.Name = "dgvImportsDetail";
            this.dgvImportsDetail.Size = new System.Drawing.Size(883, 364);
            this.dgvImportsDetail.TabIndex = 81;
            // 
            // btnExitImportsDetail
            // 
            this.btnExitImportsDetail.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitImportsDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnExitImportsDetail.Image")));
            this.btnExitImportsDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitImportsDetail.Location = new System.Drawing.Point(752, 449);
            this.btnExitImportsDetail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExitImportsDetail.Name = "btnExitImportsDetail";
            this.btnExitImportsDetail.Size = new System.Drawing.Size(135, 66);
            this.btnExitImportsDetail.TabIndex = 83;
            this.btnExitImportsDetail.Text = "Exit";
            this.btnExitImportsDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExitImportsDetail.UseVisualStyleBackColor = true;
            this.btnExitImportsDetail.Click += new System.EventHandler(this.btnExitImportsDetail_Click);
            // 
            // frmImportsDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 520);
            this.ControlBox = false;
            this.Controls.Add(this.btnExitImportsDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvImportsDetail);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmImportsDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmImportsDetail";
            this.Load += new System.EventHandler(this.frmImportsDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportsDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitImportsDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvImportsDetail;
    }
}