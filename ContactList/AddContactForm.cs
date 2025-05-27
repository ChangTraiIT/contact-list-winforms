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
            MessageBox.Show("Lưu thông tin bổ sung!");
            this.Close();
        }
    }
}
