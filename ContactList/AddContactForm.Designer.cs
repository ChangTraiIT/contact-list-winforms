namespace ContactList
{
    partial class AddContactForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Button btnLuu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblThongTin = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblThongTin.Location = new System.Drawing.Point(30, 30);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(160, 28);
            this.lblThongTin.TabIndex = 0;
            this.lblThongTin.Text = "Thông tin bổ sung";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(30, 80);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 30);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lblThongTin);
            this.Name = "AddContactForm";
            this.Text = "Thêm liên hệ mới";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
