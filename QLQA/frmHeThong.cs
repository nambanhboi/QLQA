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
    }
}
