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
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        public List<NguyenLieuPhieuNhap> DanhSachNguyenLieu { get; set; }
        public event EventHandler LuuThanhCong;

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {
            var query = "select * from NhanVien";
            cbNhanVienLap.DataSource = kn.LayDuLieu(query);
            cbNhanVienLap.DisplayMember = "TenNhanVien";
            cbNhanVienLap.ValueMember = "MaNhanVien";

            dgvDanhSachNguyenLieu.DataSource = DanhSachNguyenLieu;
            dgvDanhSachNguyenLieu.Columns["MaNCC"].Visible = false;
            dgvDanhSachNguyenLieu.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
            dgvDanhSachNguyenLieu.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvDanhSachNguyenLieu.Columns["Sdt"].HeaderText = "Số điện thoại";
            dgvDanhSachNguyenLieu.Columns["TenNguyenLieu"].HeaderText = "Tên nguyên liệu";
            dgvDanhSachNguyenLieu.Columns["DonGia"].HeaderText = "Đơn giá";
            dgvDanhSachNguyenLieu.Columns["SoLuong"].HeaderText = "Số lượng";

            txtNgayLap.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            txtTongTien.Text = DanhSachNguyenLieu.Sum(x => x.SoLuong * x.DonGia).ToString();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var idpn = Guid.NewGuid().ToString();
            string ngayFormat = txtNgayLap.Text;
            string manv = cbNhanVienLap.SelectedValue.ToString();
            string tongtien = txtTongTien.Text;
            var query_hd = string.Format("insert into PhieuNhap " +
                "values ('{0}', '{1}', '{2}', {3})",
                idpn, ngayFormat, manv, tongtien);
            if (!kn.ThucThi(query_hd))
            {
                MessageBox.Show("Lưu thất bại!");
                return;
            }
            //
            var query_ctpn = "insert into ChiTietPhieuNhap values";
            var index = 0;
            DanhSachNguyenLieu.ForEach(x =>
            {
                var idctpn = Guid.NewGuid().ToString();
                query_ctpn += string.Format("('{0}', '{1}', '{2}', {3})",
                    idctpn, idpn, x.MaNCC, x.SoLuong) + (index == DanhSachNguyenLieu.Count - 1 ? "" : ",");
                index++;
            });
            if (!kn.ThucThi(query_ctpn))
            {
                MessageBox.Show("Lưu thất bại!");
                return;
            }
            MessageBox.Show("Lưu thành công!");
            if (LuuThanhCong != null)
            {
                LuuThanhCong(this, EventArgs.Empty);
            }
            this.Close();
        }
    }
}
