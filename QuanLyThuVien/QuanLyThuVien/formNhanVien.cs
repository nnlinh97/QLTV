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
    public partial class formNhanVien : Form
    {
        public formNhanVien()
        {
            InitializeComponent();
        }

        private void btnThoatNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
