using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQA
{
    public partial class frmTaoPhieuNhap : Form
    {
        public frmTaoPhieuNhap()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        BindingList<NguyenLieuPhieuNhap> DanhSachNguyenLieu = new BindingList<NguyenLieuPhieuNhap>();
        public string MaNCCSelected { get; set; } = null;
        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            var query = "select * from NCC";
            cbNguyenLieu.DataSource = kn.LayDuLieu(query);
            cbNguyenLieu.DisplayMember = "TenNguyenLieu";
            cbNguyenLieu.ValueMember = "MaNCC";

            dvgNguyenLieu.DataSource = DanhSachNguyenLieu;
            dvgNguyenLieu.Columns["MaNCC"].Visible = false;
            dvgNguyenLieu.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
            dvgNguyenLieu.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dvgNguyenLieu.Columns["Sdt"].HeaderText = "Số điện thoại";
            dvgNguyenLieu.Columns["TenNguyenLieu"].HeaderText = "Tên nguyên liệu";
            dvgNguyenLieu.Columns["DonGia"].HeaderText = "Đơn giá";
            dvgNguyenLieu.Columns["SoLuong"].HeaderText = "Số lượng";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (nudSoLuong.Value <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                return;
            }
            var mancc = cbNguyenLieu.SelectedValue;
            var soluong = nudSoLuong.Value;
            var query = $"SELECT * from NCC where MaNCC = '{mancc}'";
            DataTable dtnglieu = kn.LayDuLieu(query);
            var nlieu = dtnglieu.Rows[0];
            if (DanhSachNguyenLieu.Count > 0)
            {
                var listMancc = DanhSachNguyenLieu.Select(x => x.MaNCC);
                if (listMancc.Contains(mancc))
                {
                    NguyenLieuPhieuNhap nlieuTrung = DanhSachNguyenLieu.FirstOrDefault(x => x.MaNCC.Equals(mancc));
                    soluong = nlieuTrung.SoLuong + soluong;
                    DanhSachNguyenLieu.Remove(nlieuTrung);
                }
            }
            var nguyenlieu = new NguyenLieuPhieuNhap()
            {
                MaNCC = nlieu["MaNCC"].ToString(),
                TenNCC = nlieu["TenNCC"].ToString(),
                TenNguyenLieu = nlieu["TenNguyenLieu"].ToString(),
                DiaChi = nlieu["DiaChi"].ToString(),
                Sdt = nlieu["Sdt"].ToString(),
                DonGia = float.Parse(nlieu["DonGia"].ToString()),
                SoLuong = (int)soluong
            };
            DanhSachNguyenLieu.Add(nguyenlieu);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát và không lưu không?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                frmHeThong frm = new frmHeThong();
                this.Hide();
                frm.Show();
            }
        }

        private void dvgNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var cellValue = dvgNguyenLieu.Rows[e.RowIndex].Cells["MaNCC"];
                if (cellValue.Value != null)
                {
                    MaNCCSelected = cellValue.Value.ToString();
                }
                else
                {
                    MaNCCSelected = null;
                }
            }
            else
            {
                MaNCCSelected = null;
            }
            var a = MaNCCSelected;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MaNCCSelected == null)
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu trước khi xóa");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                var nlieuSelected = DanhSachNguyenLieu.FirstOrDefault(x => x.MaNCC.Equals(MaNCCSelected));
                if (nlieuSelected != null) DanhSachNguyenLieu.Remove(nlieuSelected);
                nlieuSelected = null;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (DanhSachNguyenLieu.Count > 0)
            {
                frmPhieuNhap frm = new frmPhieuNhap();
                frm.DanhSachNguyenLieu = DanhSachNguyenLieu.ToList();
                frm.LuuThanhCong += Frm_LuuThanhCong;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu!");
            }
        }

        private void Frm_LuuThanhCong(object sender, EventArgs e)
        {
            nudSoLuong.Value = 0;
            DanhSachNguyenLieu.Clear();
        }
    }
}
