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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var query = string.Format("select * from TaiKhoan where TenDangNhap = '{0}' and MatKhau = '{1}'", 
                txtTenDangNhap.Text, txtMatKhau.Text);
            if(kn.LayDuLieu(query).Rows.Count > 0 )
            {
                MessageBox.Show("Đăng nhập thành công!");
                // kiểm tra xem tài khoản có phải admin hay không
                string q = string.Format("select * from TaiKhoan where TenDangNhap = '{0}' and MatKhau = '{1}' and IsAdmin = 1",
                txtTenDangNhap.Text, txtMatKhau.Text);
                if(kn.LayDuLieu(q).Rows.Count > 0 )
                {
                    AppGlobal.IsAdmin = true;
                }
                else
                {
                    AppGlobal.IsAdmin=false;
                }
                this.Hide();
                frmHeThong frm = new frmHeThong();
                frm.Show();
                MessageBox.Show(AppGlobal.IsAdmin.ToString());
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!");
            }
        }
    }
}
