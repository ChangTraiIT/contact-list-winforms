using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnThemLienHe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã nhấn nút Thêm liên hệ!");
            AddContactForm addForm = new AddContactForm();
            addForm.ShowDialog();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}