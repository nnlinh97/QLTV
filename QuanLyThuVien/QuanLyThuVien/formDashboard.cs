using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class formDashboard : Form
    {
        public formDashboard()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmChangePassword f = new frmChangePassword();
            f.Show();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formSach f = new formSach();
            f.ShowDialog();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formNXB f = new formNXB();
            f.ShowDialog();
        }

        private void loạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLoaiSach f = new formLoaiSach();
            f.ShowDialog();
        }
    }
}
