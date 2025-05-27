namespace ContactList
{
    partial class MainForm
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
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.btnThemLienHe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSach.Location = new System.Drawing.Point(30, 30);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(180, 32);
            this.lblDanhSach.TabIndex = 0;
            this.lblDanhSach.Text = "Danh sách liên hệ";
            // 
            // btnThemLienHe
            // 
            this.btnThemLienHe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThemLienHe.Location = new System.Drawing.Point(30, 80);
            this.btnThemLienHe.Name = "btnThemLienHe";
            this.btnThemLienHe.Size = new System.Drawing.Size(150, 35);
            this.btnThemLienHe.TabIndex = 1;
            this.btnThemLienHe.Text = "Thêm liên hệ";
            this.btnThemLienHe.UseVisualStyleBackColor = true;
            this.btnThemLienHe.Click += new System.EventHandler(this.btnThemLienHe_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThemLienHe);
            this.Controls.Add(this.lblDanhSach);
            this.Name = "MainForm";
            this.Text = "Quản lý liên hệ";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.Button btnThemLienHe;
    }
}
