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
    public partial class frmQuanLyThongTin : Form
    {
        KetNoi kn = new KetNoi();
        public frmQuanLyThongTin()
        {
            InitializeComponent();
        }
        //Form Tài khoản
        private void frmQuanLyThongTin_Load(object sender, EventArgs e)
        {
            // tài khoản
            TkGetData();
            TkClearText();

            //nhân viên
            NvClearText();
            NvGetData();

            //ncc
            NccClearText();
            NccGetData();

            //món
            MonClearText();
            MonGetData();

            // bàn
            BanClearText();
            BanGetData();

            //bảng lương
            BangLuongClearText();
            BangLuongGetData();
        }
        public void TkGetData()
        {
            string query = "select * from TaiKhoan";
            TkDvgTaiKhoan.DataSource = kn.LayDuLieu(query);

            TkDvgTaiKhoan.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
            TkDvgTaiKhoan.Columns["MatKhau"].HeaderText = "Mật khẩu";
            TkDvgTaiKhoan.Columns["IsAdmin"].HeaderText = "Quyền";
        }
        public void TkClearText()
        {
            tkTxtTenDangNhap.Enabled = true;
            TkBtnThemMoi.Enabled = true;
            TkBtnSua.Enabled = false;
            TkBtnXoa.Enabled = false;

            tkTxtTenDangNhap.Text = "";
            TkTxtMatKhau.Text = "";
            TkTxtTimKiem.Text = "";
            TkRdAdmin.Checked = true;
        }

        private void TkBtnThemMoi_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into TaiKhoan values ('{0}','{1}', {2})",
                    tkTxtTenDangNhap.Text,
                    TkTxtMatKhau.Text,
                    TkRdAdmin.Checked ? 1 : 0
                );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Thêm thành công");
                TkBtnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void TkBtnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format("update TaiKhoan set MatKhau = '{1}', IsAdmin = {2} where TenDangNhap = '{0}'",
                tkTxtTenDangNhap.Text,
                TkTxtMatKhau.Text,
                TkRdAdmin.Checked ? 1 : 0
            );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Sửa thành công");
                TkBtnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void TkBtnXoa_Click(object sender, EventArgs e)
        {
            string query = string.Format("delete from TaiKhoan where TenDangNhap = '{0}'", tkTxtTenDangNhap.Text);
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("xoa thanh cong");
                TkBtnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("xoa that bai");
            }
        }

        private void TkBtnLamMoi_Click(object sender, EventArgs e)
        {
            TkClearText();
            TkGetData();
        }

        private void TkDvgTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                tkTxtTenDangNhap.Enabled = false;
                TkBtnThemMoi.Enabled = false;
                TkBtnSua.Enabled = true;
                TkBtnXoa.Enabled = true;

                tkTxtTenDangNhap.Text = TkDvgTaiKhoan.Rows[r].Cells["TenDangNhap"].Value.ToString();
                TkTxtMatKhau.Text = TkDvgTaiKhoan.Rows[r].Cells["MatKhau"].Value.ToString();
                if (TkDvgTaiKhoan.Rows[r].Cells["IsAdmin"].Value.ToString() == "1")
                {
                    TkRdAdmin.Checked = true;
                }
                else
                {
                    TkRdNhanVien.Checked = true;
                }
            }
        }

        private void TkBtnTimKiem_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from TaiKhoan where TenDangNhap like N'%{0}%'", TkTxtTimKiem.Text);
            TkDvgTaiKhoan.DataSource = kn.LayDuLieu(query);
        }



        // quản lý nhân viên

        public void NvGetData()
        {
            string query = "select * from NhanVien";
            NvDvgNhanVien.DataSource = kn.LayDuLieu(query);

            NvDvgNhanVien.Columns["MaNhanVien"].Visible = false;
            NvDvgNhanVien.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            NvDvgNhanVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
            NvDvgNhanVien.Columns["Sdt"].HeaderText = "Số điện thoại";
            NvDvgNhanVien.Columns["DonLuong"].HeaderText = "Đơn lương";
        }
        public void NvClearText()
        {
            NvBtnThemMoi.Enabled = true;
            NvBtnSua.Enabled = false;
            NvBtnXoa.Enabled = false;

            AppGlobal.MaNhanVien = "";
            NvTxtHoVaTen.Text = "";
            NvTxtDiaChi.Text = "";
            NvTxtSdt.Text = "";
            NvNudDonLuong.Value = 0;
            NvTxtTimKiem.Text = "";
        }

        private void NvBtnThemMoi_Click(object sender, EventArgs e)
        {
            var manv = Guid.NewGuid().ToString();
            string query = string.Format("insert into NhanVien values ('{0}','{1}', '{2}', '{3}', {4})",
                    manv,
                    NvTxtHoVaTen.Text,
                    NvTxtDiaChi.Text,
                    NvTxtSdt.Text,
                    NvNudDonLuong.Value
                );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Thêm thành công");
                NvBtnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void NvBtnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format("update NhanVien set TenNhanVien = '{1}', DiaChi = '{2}', Sdt = '{3}', DonLuong = {4} where MaNhanVien = '{0}'",
                AppGlobal.MaNhanVien,
                NvTxtHoVaTen.Text,
                NvTxtDiaChi.Text,
                NvTxtSdt.Text,
                NvNudDonLuong.Value
            );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Sửa thành công");
                NvBtnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void NvBtnXoa_Click(object sender, EventArgs e)
        {
            string query = string.Format("delete from NhanVien where MaNhanVien = '{0}'", AppGlobal.MaNhanVien);
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Xóa thành công");
                NvBtnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void NvBtnLamMoi_Click(object sender, EventArgs e)
        {
            NvClearText();
            NvGetData();
        }

        private void NvBtnTimKiem_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from NhanVien where TenNhanVien like N'%{0}%' or DiaChi like N'%{0}%' or Sdt like N'%{0}%'", NvTxtTimKiem.Text);
            NvDvgNhanVien.DataSource = kn.LayDuLieu(query);
        }

        private void NvDvgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                NvBtnThemMoi.Enabled = false;
                NvBtnSua.Enabled = true;
                NvBtnXoa.Enabled = true;

                AppGlobal.MaNhanVien = NvDvgNhanVien.Rows[r].Cells["MaNhanVien"].Value.ToString();
                NvTxtHoVaTen.Text = NvDvgNhanVien.Rows[r].Cells["TenNhanVien"].Value.ToString();
                NvTxtDiaChi.Text = NvDvgNhanVien.Rows[r].Cells["DiaChi"].Value.ToString();
                NvTxtSdt.Text = NvDvgNhanVien.Rows[r].Cells["Sdt"].Value.ToString();
                int donLuong;
                if (Int32.TryParse(NvDvgNhanVien.Rows[r].Cells["DonLuong"].Value.ToString(), out donLuong))
                {
                    NvNudDonLuong.Value = donLuong;
                }
                else
                {
                    NvNudDonLuong.Value = 0;
                }
            }
        }


        // NCC
        public void NccGetData()
        {
            string query = "select * from NCC";
            NccDvgNCC.DataSource = kn.LayDuLieu(query);

            NccDvgNCC.Columns["MaNCC"].Visible = false;
            NccDvgNCC.Columns["TenNCC"].HeaderText = "Tên NCC";
            NccDvgNCC.Columns["DiaChi"].HeaderText = "Địa chỉ";
            NccDvgNCC.Columns["Sdt"].HeaderText = "Số điện thoại";
            NccDvgNCC.Columns["TenNguyenLieu"].HeaderText = "Tên nguyên liệu";
            NccDvgNCC.Columns["DonGia"].HeaderText = "Đơn giá";
        }
        public void NccClearText()
        {
            NccBtnThemMoi.Enabled = true;
            NccBtnSua.Enabled = false;
            NccBtnXoa.Enabled = false;

            AppGlobal.MaNCC = "";
            NccTxtTenNCC.Text = "";
            NccTxtDiaChi.Text = "";
            NccTxtSdt.Text = "";
            NccTxtTenNguyenLieu.Text = "";
            NccNudDonGia.Value = 0;
            NccTxtTimKiem.Text = "";
        }


        private void NccBtnThemMoi_Click(object sender, EventArgs e)
        {
            var mancc = Guid.NewGuid().ToString();
            string query = string.Format("insert into NCC values ('{0}','{1}', '{2}', '{3}', '{4}', {5})",
                    mancc,
                    NccTxtTenNCC.Text,
                    NccTxtDiaChi.Text,
                    NccTxtSdt.Text,
                    NccTxtTenNguyenLieu.Text,
                    NccNudDonGia.Value
                );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Thêm thành công");
                NccBtnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void NccBtnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format("update NCC set TenNCC = '{1}', DiaChi = '{2}', Sdt = '{3}', TenNguyenLieu = '{4}', DonGia = {5} where MaNCC = '{0}'",
                AppGlobal.MaNCC,
                NccTxtTenNCC.Text,
                NccTxtDiaChi.Text,
                NccTxtSdt.Text,
                NccTxtTenNguyenLieu.Text,
                NccNudDonGia.Value
            );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Sửa thành công");
                NccBtnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void NccBtnXoa_Click(object sender, EventArgs e)
        {
            string query = string.Format("delete from NCC where MaNCC = '{0}'", AppGlobal.MaNCC);
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Xóa thành công");
                NccBtnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void NccBtnLamMoi_Click(object sender, EventArgs e)
        {
            NccClearText();
            NccGetData();
        }

        private void NccBtnTimKiem_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from NCC where TenNCC like N'%{0}%' or DiaChi like N'%{0}%' or Sdt like N'%{0}%' or TenNguyenLieu like N'%{0}%'", NccTxtTimKiem.Text);
            NccDvgNCC.DataSource = kn.LayDuLieu(query);
        }

        private void NccDvgNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                NccBtnThemMoi.Enabled = false;
                NccBtnSua.Enabled = true;
                NccBtnXoa.Enabled = true;

                AppGlobal.MaNCC = NccDvgNCC.Rows[r].Cells["MaNCC"].Value.ToString();
                NccTxtTenNCC.Text = NccDvgNCC.Rows[r].Cells["TenNCC"].Value.ToString();
                NccTxtDiaChi.Text = NccDvgNCC.Rows[r].Cells["DiaChi"].Value.ToString();
                NccTxtSdt.Text = NccDvgNCC.Rows[r].Cells["Sdt"].Value.ToString();
                NccTxtTenNguyenLieu.Text = NccDvgNCC.Rows[r].Cells["TenNguyenLieu"].Value.ToString();
                int donGia;
                if (Int32.TryParse(NccDvgNCC.Rows[r].Cells["DonGia"].Value.ToString(), out donGia))
                {
                    NccNudDonGia.Value = donGia;
                }
                else
                {
                    NccNudDonGia.Value = 0;
                }
            }
        }


        // món
        public void MonGetData()
        {
            string query = "select * from Mon";
            MonDvgMon.DataSource = kn.LayDuLieu(query);

            MonDvgMon.Columns["MaMon"].Visible = false;
            MonDvgMon.Columns["TenMon"].HeaderText = "Tên món";
            MonDvgMon.Columns["MoTa"].HeaderText = "Mô tả";
            MonDvgMon.Columns["GiaBan"].HeaderText = "Giá bán";
        }
        public void MonClearText()
        {
            MonBtnThemMoi.Enabled = true;
            MonBtnSua.Enabled = false;
            MonBtnXoa.Enabled = false;

            AppGlobal.MaMon = "";
            MonTxtTenMon.Text = "";
            MonRtxMoTa.Text = "";
            MonNudGiaBan.Value = 0;
            MonTxtTimKiem.Text = "";
        }


        private void MonBtnThemMoi_Click(object sender, EventArgs e)
        {
            var mamon = Guid.NewGuid().ToString();
            string query = string.Format("insert into Mon values ('{0}','{1}', '{2}', {3})",
                    mamon,
                    MonTxtTenMon.Text,
                    MonRtxMoTa.Text,
                    MonNudGiaBan.Value
                );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Thêm thành công");
                MonBtnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void MonBtnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format("update Mon set TenMon = '{1}', MoTa = '{2}', GiaBan = {3} where MaMon = '{0}'",
                AppGlobal.MaMon,
                MonTxtTenMon.Text,
                MonRtxMoTa.Text,
                MonNudGiaBan.Value
            );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Sửa thành công");
                MonBtnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void MonBtnXoa_Click(object sender, EventArgs e)
        {
            string query = string.Format("delete from Mon where MaMon = '{0}'", AppGlobal.MaMon);
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Xóa thành công");
                MonBtnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void MonBtnLamMoi_Click(object sender, EventArgs e)
        {
            MonClearText();
            MonGetData();
        }

        private void MonBtnTimKiem_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from Mon where TenMon like N'%{0}%' or MoTa like N'%{0}%'", MonTxtTimKiem.Text);
            MonDvgMon.DataSource = kn.LayDuLieu(query);
        }

        private void MonDvgMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                MonBtnThemMoi.Enabled = false;
                MonBtnSua.Enabled = true;
                MonBtnXoa.Enabled = true;

                AppGlobal.MaMon = MonDvgMon.Rows[r].Cells["MaMon"].Value.ToString();
                MonTxtTenMon.Text = MonDvgMon.Rows[r].Cells["TenMon"].Value.ToString();
                MonRtxMoTa.Text = MonDvgMon.Rows[r].Cells["MoTa"].Value.ToString();
                int donGia;
                if (Int32.TryParse(MonDvgMon.Rows[r].Cells["GiaBan"].Value.ToString(), out donGia))
                {
                    MonNudGiaBan.Value = donGia;
                }
                else
                {
                    MonNudGiaBan.Value = 0;
                }
            }
        }

        // Bàn
        public void BanGetData()
        {
            string query = "select * from Ban";
            BanDvgBan.DataSource = kn.LayDuLieu(query);

            BanDvgBan.Columns["MaBan"].Visible = false;
            BanDvgBan.Columns["TenBan"].HeaderText = "Tên bàn";
        }
        public void BanClearText()
        {
            BanBTnThemMoi.Enabled = true;
            BanBtnSua.Enabled = false;
            BanBtnXoa.Enabled = false;

            AppGlobal.MaBan = "";
            BanTxtBan.Text = "";
            BanTxtTimKiem.Text = "";
        }

        private void BanBTnThemMoi_Click(object sender, EventArgs e)
        {
            var maban = Guid.NewGuid().ToString();
            string query = string.Format("insert into Ban values ('{0}','{1}')",
                    maban,
                    BanTxtBan.Text
                );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Thêm thành công");
                BanBtnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }


        private void BanBtnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format("update Ban set TenBan = '{1}' where MaBan = '{0}'",
                AppGlobal.MaBan,
                BanTxtBan.Text
            );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Sửa thành công");
                BanBtnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void BanBtnXoa_Click(object sender, EventArgs e)
        {
            string query = string.Format("delete from Ban where MaBan = '{0}'", AppGlobal.MaBan);
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Xóa thành công");
                BanBtnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void BanBtnLamMoi_Click(object sender, EventArgs e)
        {
            BanClearText();
            BanGetData();
        }

        private void BanBtnTimKiem_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from Ban where TenBan like N'%{0}%'", BanTxtTimKiem.Text);
            BanDvgBan.DataSource = kn.LayDuLieu(query);
        }
        private void BanDvgBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                BanBTnThemMoi.Enabled = false;
                BanBtnSua.Enabled = true;
                BanBtnXoa.Enabled = true;

                AppGlobal.MaBan = BanDvgBan.Rows[r].Cells["MaBan"].Value.ToString();
                BanTxtBan.Text = BanDvgBan.Rows[r].Cells["TenBan"].Value.ToString();
            }
        }

        // bảng lương
        public void BangLuongGetData()
        {
            string query = "select MaBangLuong, Thang, Nam, BangLuong.MaNhanVien, TenNhanVien, SoCong, Thuong, Phat, TongLuong from BangLuong inner join NhanVien on BangLuong.MaNhanVien = NhanVien.MaNhanVien";
            BlDvgBangLuong.DataSource = kn.LayDuLieu(query);

            BlDvgBangLuong.Columns["MaBangLuong"].Visible = false;
            BlDvgBangLuong.Columns["MaNhanVien"].Visible = false;
            BlDvgBangLuong.Columns["Thang"].HeaderText = "Tháng";
            BlDvgBangLuong.Columns["Nam"].HeaderText = "Năm";
            BlDvgBangLuong.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            BlDvgBangLuong.Columns["SoCong"].HeaderText = "Số công";
            BlDvgBangLuong.Columns["Thuong"].HeaderText = "Thưởng";
            BlDvgBangLuong.Columns["Phat"].HeaderText = "Phạt";
            BlDvgBangLuong.Columns["TongLuong"].HeaderText = "Tổng lương";


            BangLuongGetNhanVien();

        }
        public void BangLuongGetNhanVien()
        {
            string queryNv = "select * from NhanVien";
            BlCbNhanVien.DataSource = kn.LayDuLieu(queryNv);
            BlCbNhanVien.DisplayMember = "TenNhanVien";
            BlCbNhanVien.ValueMember = "MaNhanVien";
        }
        public void BangLuongClearText()
        {
            BlBtnThemMoi.Enabled = true;
            BlBtnSua.Enabled = false;
            BlBtnXoa.Enabled = false;
            BlNudThang.Enabled = true;
            BlNudNam.Enabled = true;
            BlCbNhanVien.Enabled = true;

            AppGlobal.MaBangLuong = "";
            BlNudThang.Value = 1;
            BlNudNam.Value = 2023;
            BangLuongGetNhanVien();
            BlNudSoCong.Value = 0;
            BlNudThuong.Value = 0;
            BlNudPhat.Value = 0;
            BlTxtTimKiem.Text = "";
        }

        private void BlBtnThemMoi_Click(object sender, EventArgs e)
        {
            var mabl = Guid.NewGuid().ToString();
            string query = string.Format("insert into BangLuong values ('{0}', {1}, {2}, '{3}', {4}, {5}, {6}, null)",
                    mabl,
                    BlNudThang.Value,
                    BlNudNam.Value,
                    BlCbNhanVien.SelectedValue,
                    BlNudSoCong.Value,
                    BlNudThuong.Value,
                    BlNudPhat.Value
                );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Thêm thành công");
                BlBtnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void BlBtnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format("update BangLuong set SoCong = {1}, Thuong = {2}, Phat = {3} where MaBangLuong = '{0}'",
                AppGlobal.MaBangLuong,
                BlNudSoCong.Value,
                BlNudThuong.Value,
                BlNudPhat.Value
            );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Sửa thành công");
                BlBtnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void BlBtnXoa_Click(object sender, EventArgs e)
        {
            string query = string.Format("delete from BangLuong where MaBangLuong = '{0}'", AppGlobal.MaBangLuong);
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Xóa thành công");
                BlBtnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void BlBtnLamMoi_Click(object sender, EventArgs e)
        {
            BangLuongClearText();
            BangLuongGetData();
        }

        private void BlBtnTimKiem_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from BangLuong inner join NhanVien on BangLuong.MaNhanVien = NhanVien.MaNhanVien where Thang = {0} or Nam = {0} or TenNhanVien like N'%{0}%'", MonTxtTimKiem.Text);
            BlDvgBangLuong.DataSource = kn.LayDuLieu(query);
        }
        private void BlDvgBangLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                BlBtnThemMoi.Enabled = false;
                BlBtnSua.Enabled = true;
                BlBtnXoa.Enabled = true;
                BlNudThang.Enabled = false;
                BlNudNam.Enabled = false;
                BlCbNhanVien.Enabled = false;

                AppGlobal.MaBangLuong = BlDvgBangLuong.Rows[r].Cells["MaBangLuong"].Value.ToString();
                int so;
                BlNudThang.Value = Int32.TryParse(BlDvgBangLuong.Rows[r].Cells["Thang"].Value.ToString(), out so) ? so : 0;
                BlNudNam.Value = Int32.TryParse(BlDvgBangLuong.Rows[r].Cells["Nam"].Value.ToString(), out so) ? so : 0;
                BlCbNhanVien.SelectedValue = BlDvgBangLuong.Rows[r].Cells["MaNhanVien"].Value.ToString();
                BlNudSoCong.Value = Int32.TryParse(BlDvgBangLuong.Rows[r].Cells["SoCong"].Value.ToString(), out so) ? so : 0;
                BlNudThuong.Value = Int32.TryParse(BlDvgBangLuong.Rows[r].Cells["Thuong"].Value.ToString(), out so) ? so : 0;
                BlNudPhat.Value = Int32.TryParse(BlDvgBangLuong.Rows[r].Cells["Phat"].Value.ToString(), out so) ? so : 0;

            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát và không lưu không?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                frmHeThong frm = new frmHeThong();
                this.Hide();
                frm.Show();
            }
        }
    }
}
