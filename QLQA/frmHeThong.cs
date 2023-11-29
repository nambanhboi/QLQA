using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQA
{
    public partial class frmHeThong : Form
    {
        public frmHeThong()
        {
            InitializeComponent();
            if (!AppGlobal.IsAdmin)
            {
                btnQltt.Visible = false;
            }
        }
        private void btnQltt_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyThongTin frm = new frmQuanLyThongTin();
            frm.Show();
        }

        private void btnQlba_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyBanAn frm = new frmQuanLyBanAn();
            frm.Show();
        }

        private void frmHeThong_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frm = new frmDangNhap();
            AppGlobal.IsAdmin = false;
            frm.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();
            this.Hide();
            frm.Show();
        }

        private void btnPn_Click(object sender, EventArgs e)
        {
            frmTaoPhieuNhap frm = new frmTaoPhieuNhap();
            this.Hide();
            frm.Show();
        }
    }
}
