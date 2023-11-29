using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLQA
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            var datenow = DateTime.Now;
            nudThang.Value = datenow.Month;
            nudNam.Value = datenow.Year;
            getData(datenow.Month, datenow.Year);
        }

        public void getData(int thang, int nam)
        {
            string query = "select Ngay, Ban.MaBan, TenBan, HoaDon.MaNhanVien, TenNhanVien, TenKhachHang, HoaDon.Sdt, TongTien " +
                "from HoaDon\r\ninner join NhanVien on HoaDon.MaNhanVien = NhanVien.MaNhanVien " +
                "inner join Ban on HoaDon.MaBan = Ban.MaBan " +
                $"where MONTH(Ngay) = {thang} and year(Ngay) = {nam}";
            dvgHoaDon.DataSource = kn.LayDuLieu(query);
            if (dvgHoaDon != null && dvgHoaDon.Rows.Count > 0)
            {
                dvgHoaDon.Columns["Ngay"].HeaderText = "Ngày";
                dvgHoaDon.Columns["MaBan"].Visible = false;
                dvgHoaDon.Columns["MaNhanVien"].Visible = false;
                dvgHoaDon.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
                dvgHoaDon.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
                dvgHoaDon.Columns["Sdt"].HeaderText = "Số điện thoại";
                dvgHoaDon.Columns["TongTien"].HeaderText = "Tổng tiền";
            }


            string queryDt = $"SELECT SUM(TongTien) AS DoanhThu FROM HoaDon WHERE MONTH(Ngay) = {thang} AND YEAR(Ngay) = {nam}";
            DataTable dataTable = kn.LayDuLieu(queryDt);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                txtDoanhThu.Text = dataTable.Rows[0]["DoanhThu"].ToString() != "NULL" ? dataTable.Rows[0]["DoanhThu"].ToString() : "0";
            }
            else
            {
                txtDoanhThu.Text = "0";
            }

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            getData((int)nudThang.Value, (int)nudNam.Value);
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
    }
}
