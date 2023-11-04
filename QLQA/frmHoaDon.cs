using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQA
{
    public partial class frmHoaDon : Form
    {
        KetNoi kn = new KetNoi();
        public string? MaBan { get; set; }
        public string? TenBan { get; set; }
        public string? TongTien { get; set; }
        public string? Sale { get; set; }
        public string? ThanhTien { get; set; }
        public List<MonAnHoaDon>? monAnHoaDons { get; set; }
        public event EventHandler ThanhToanThanhCong;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            var query = "select * from NhanVien";
            DataTable tb = new DataTable();
            tb = kn.LayDuLieu(query);
            cbNhanVienLap.DataSource = tb;
            cbNhanVienLap.DisplayMember = "TenNhanVien";
            cbNhanVienLap.ValueMember = "MaNhanVien";
            //
            dgvDanhSachMon.DataSource = monAnHoaDons;
            txtBan.Text = TenBan;
            txtNgayLap.Text = DateTime.Now.ToString();
            txtSales.Text = Sale;
            txtTongTien.Text = TongTien;
            txtThanhTien.Text = ThanhTien;
        }

        public bool checkData()
        {
            if (string.IsNullOrEmpty(txtTenKhachHang.Text) || string.IsNullOrEmpty(txtSoDienThoai.Text) || string.IsNullOrEmpty(cbNhanVienLap.SelectedValue.ToString())) return false;
            return true;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (!checkData())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            var idhd = Guid.NewGuid().ToString();
            string ngayFormat = txtNgayLap.Text.Substring(0, txtNgayLap.Text.Length - 3);
            var query_hd = string.Format("insert into HoaDon " +
                "values ('{0}', '{1}', '{2}', NUll, '{3}', '{4}', {5})",
                idhd, ngayFormat, MaBan, txtTenKhachHang.Text, txtSoDienThoai.Text, ThanhTien);
            if(!kn.ThucThi(query_hd))
            {
                MessageBox.Show("Thanh toán thất bại!");
                return;
            }
            //
            var query_cthd = "insert into ChiTietHoaDon values";
            var index = 0;
            monAnHoaDons.ForEach(x =>
            {
                var idcthd = Guid.NewGuid().ToString();
                query_cthd += string.Format("('{0}', '{1}', '{2}', {3})",
                    idcthd, idhd, x.MaMon, x.SoLuong) + (index == monAnHoaDons.Count - 1 ? "" : ",");
                index++;
            });
            if(!kn.ThucThi(query_cthd))
            {
                MessageBox.Show("Thanh toán thất bại!");
                return;
            }
            MessageBox.Show("Thanh toán thành công!");
            frmQuanLyBanAn frm = new frmQuanLyBanAn();
            if (ThanhToanThanhCong != null)
            {
                ThanhToanThanhCong(this, EventArgs.Empty);
            }
            this.Hide();            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
