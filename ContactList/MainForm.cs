using System;
using System.Windows.Forms;

namespace ContactList
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Sự kiện này vẫn được giữ lại nhưng không còn gọi AddContactForm
        private void btnThemLienHe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng thêm liên hệ đã bị xóa.");
        }
    }
}
