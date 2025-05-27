using System;
using System.Windows.Forms;

namespace ContactList
{
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ten = txtHoTen.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();

            if (string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ tên và số điện thoại.");
                return;
            }

            MessageBox.Show($"Liên hệ đã lưu:\nHọ tên: {ten}\nSĐT: {sdt}", "Thông báo");
            this.Close();
        }
    }
}
