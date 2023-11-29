using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQA
{
    public partial class frmQuanLyBanAn : Form
    {
        KetNoi kn = new KetNoi();
        public static int curentIndexBan = 0;
        public static List<BanAn> danhSachBanAn = new List<BanAn>();
        public static List<MonAn> danhSachMon = new List<MonAn>();
        public static string curentMaMonRow = null;
        public frmQuanLyBanAn()
        {
            InitializeComponent();
        }

        public void layma()
        {


        }

        private void frmQuanLyBanAn_Load(object sender, EventArgs e)
        {
            getData();
            getDgvDanhSachMon();
        }

        public void getData()
        {
            var query = "select * from Ban";
            DataTable tb = new DataTable();
            tb = kn.LayDuLieu(query);

            // lấy ra các bàn fill combobox để chuyển bàn
            cbBan.DataSource = tb;
            cbBan.DisplayMember = "TenBan";
            cbBan.ValueMember = "MaBan";

            foreach (DataRow row in tb.Rows)
            {
                // lấy ra maban và ten bàn
                string MaBan = row["MaBan"].ToString();
                string TenBan = row["TenBan"].ToString();

                // tạo ra một danh sách bàn ăn gồm mã bàn, tên bàn, trnagj thái trống, danh sách các món ăn
                danhSachBanAn.Add(new BanAn()
                {
                    MaBan = MaBan,
                    TenBan = TenBan,
                    DanhSachMonAns = new BindingList<MonAnTrongBan>() // sử dụng bindingliset để theo dõi sự thay đổi cảu datagridview
                });

                // css cho các btn bàn lúc mới khởi tạo

                Button btn = new Button();
                btn.Text = TenBan;
                btn.Name = MaBan;
                btn.BackColor = Color.Green;
                btn.Width = 140;
                btn.Height = 120;
                btn.ForeColor = Color.White;

                //sự kiện click
                btn.Click += (s, e) =>
                {
                    curentIndexBan = danhSachBanAn.FindIndex(ban => ban.MaBan == btn.Name);
                    getDgvDanhSachMon();
                    KiemTraBan();
                    curentMaMonRow = null;
                    //txtTamTinh.Text = danhSachBanAn[curentIndexBan].DanhSachMonAns.Select(x => x.)
                };

                flpBan.Controls.Add(btn);
            }

            // lấy ra danh sách các món đổ vào cb món
            var queryMon = "select * from Mon";
            DataTable tbmon = new DataTable();
            tbmon = kn.LayDuLieu(queryMon);
            cbMon.DataSource = tbmon;
            cbMon.DisplayMember = "TenMon";
            cbMon.ValueMember = "MaMon";

            // lấy ra danh sách món
            foreach (DataRow row in tbmon.Rows)
            {
                danhSachMon.Add(new MonAn
                {
                    MaMon = row["MaMon"].ToString(),
                    DonGia = row["GiaBan"].ToString()
                });
            }


        }
        // lấy ra danh sách các món với bàn hiện tại được chọn đổ vào dgvdanhsachmon
        public void getDgvDanhSachMon()
        {
            dgvDanhSachMon.DataSource = danhSachBanAn[curentIndexBan].DanhSachMonAns;
            dgvDanhSachMon.Columns["MaMon"].Visible = false;
            dgvDanhSachMon.Columns["TenMon"].HeaderText = "Tên món";
            dgvDanhSachMon.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvDanhSachMon.Columns["DonGia"].HeaderText = "Đơn giá";
        }
        // sự kiện click thêm món
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            // lấy ra ma món và số lượng để đổ vào danhsachmonawn trong bàn
            var mamon = cbMon.SelectedValue.ToString();
            var soluong = (int)nudSoLuongMon.Value;
            if (soluong <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng!");
                return;
            };
            var listMaMon = danhSachBanAn[curentIndexBan].DanhSachMonAns.Select(x => x.MaMon);
            if (listMaMon.Contains(mamon))
            {
                // nếu list mamon chứa món đó rồi thì xóa món í đi và thêm món đấy với số lượng mới
                var montrung = danhSachBanAn[curentIndexBan].DanhSachMonAns.FirstOrDefault(x => x.MaMon == mamon);
                soluong = montrung.SoLuong + soluong;
                danhSachBanAn[curentIndexBan].DanhSachMonAns.Remove(montrung);
            }
            // nếu chưa có thì thêm như bình thường
            var newMon = new MonAnTrongBan()
            {
                MaMon = mamon,
                TenMon = cbMon.Text,
                SoLuong = soluong,
                DonGia = float.Parse(danhSachMon.FirstOrDefault(x => x.MaMon == mamon).DonGia),
            };
            danhSachBanAn[curentIndexBan].DanhSachMonAns.Add(newMon);
            //getDgvDanhSachMon();
            // kiểm tra nếu danh sách món tại bàn hiện tại nếu có thì đổ màu đỏ không thì đổ màu xanh
            KiemTraBan();
            var a = danhSachBanAn;
            var b = dgvDanhSachMon.DataSource;
        }
        public void KiemTraBan()
        {
            var maban = danhSachBanAn[curentIndexBan].MaBan;
            Button targetButton = null;
            foreach (Control control in flpBan.Controls)
            {
                if (control is Button button && button.Name == maban) targetButton = button;
            }
            if (targetButton != null)
            {
                if (danhSachBanAn[curentIndexBan].DanhSachMonAns.Count > 0)
                {
                    targetButton.BackColor = Color.Red;
                }
                else
                {
                    targetButton.BackColor = Color.Green;
                }

            }

            // fill ô tạm tính
            float tienTamTinh = 0;
            if (danhSachBanAn[curentIndexBan].DanhSachMonAns != null)
            {
                foreach (var mon in danhSachBanAn[curentIndexBan].DanhSachMonAns)
                {
                    tienTamTinh += mon.DonGia * mon.SoLuong;
                }
            }
            txtTamTinh.Text = tienTamTinh.ToString();
            txtTongTien.Text = (tienTamTinh - tienTamTinh * (int)nudSale.Value / 100).ToString();
        }

        private void nudSale_ValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTamTinh.Text))
            {
                txtTongTien.Text = (float.Parse(txtTamTinh.Text) - float.Parse(txtTamTinh.Text) * (int)nudSale.Value / 100).ToString();
            }
        }

        private void dvgDanhSachMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var cellValue = dgvDanhSachMon.Rows[e.RowIndex].Cells["MaMon"];
                if (cellValue.Value != null)
                {
                    curentMaMonRow = cellValue.Value.ToString();
                }
                else
                {
                    curentMaMonRow = null;
                }
            }
            else
            {
                curentMaMonRow = null;
            }
            var a = curentMaMonRow;
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (curentMaMonRow == null)
            {
                MessageBox.Show("Vui lòng chọn món trước khi xóa");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                var monSelected = danhSachBanAn[curentIndexBan].DanhSachMonAns.FirstOrDefault(x => x.MaMon == curentMaMonRow);
                if (monSelected != null) danhSachBanAn[curentIndexBan].DanhSachMonAns.Remove(monSelected);
                curentMaMonRow = null;
                KiemTraBan();
            }
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            if (danhSachBanAn[curentIndexBan].DanhSachMonAns != null)
            {
                var banSelected = cbBan.SelectedValue.ToString();
                var indexBanSelected = danhSachBanAn.FindIndex(x => x.MaBan == banSelected);
                if (danhSachBanAn[curentIndexBan].DanhSachMonAns != null)
                {
                    while (danhSachBanAn[curentIndexBan].DanhSachMonAns.Count > 0)
                    {
                        danhSachBanAn[indexBanSelected].DanhSachMonAns.Add(danhSachBanAn[curentIndexBan].DanhSachMonAns[0]);
                        danhSachBanAn[curentIndexBan].DanhSachMonAns.Remove(danhSachBanAn[curentIndexBan].DanhSachMonAns[0]);
                    }
                    KiemTraBan();
                    curentIndexBan = indexBanSelected;
                    KiemTraBan();
                    getDgvDanhSachMon();
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (danhSachBanAn[curentIndexBan].DanhSachMonAns.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn món!");
                return;
            }
            frmHoaDon frm = new frmHoaDon();
            frm.MdiParent = this;
            frm.MaBan = danhSachBanAn[curentIndexBan].MaBan;
            frm.TenBan = danhSachBanAn[curentIndexBan].TenBan;
            frm.TongTien = txtTamTinh.Text;
            frm.Sale = (float.Parse(txtTamTinh.Text) * (int)nudSale.Value / 100).ToString();
            frm.ThanhTien = txtTongTien.Text;
            frm.monAnHoaDons = danhSachBanAn[curentIndexBan].DanhSachMonAns.Select((x, i) => new MonAnHoaDon
            {
                MaMon = x.MaMon,
                STT = i + 1,
                DonGia = x.DonGia,
                SoLuong = x.SoLuong,
                TenMon = x.TenMon,
                ThanhTien = x.DonGia * x.SoLuong
            }).ToList();
            frm.ThanhToanThanhCong += Frm_ThanhToanThanhCong;
            frm.Show();
        }
        public void ClearMon()
        {
            danhSachBanAn[curentIndexBan].DanhSachMonAns.Clear();
            var a = danhSachBanAn[curentIndexBan].DanhSachMonAns;
            KiemTraBan();
        }
        private void Frm_ThanhToanThanhCong(object sender, EventArgs e)
        {
            ClearMon();
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


    /// <summary>
    /// Xử lý trường hợp thêm món mà bên trong bàn đã có món đó rồi => done
    /// xử lý màu thể hiện tình trạng bàn => done
    /// cho phép xóa món => done
    /// ô textbox tạm tính: có nên hiển thị cả đơn giá ra không => done
    /// ô tổng tiền bằng tạm tính - tạm tính* ô sale => done
    /// chức năng chuyển bàn => done
    /// 
    /// thanh toán thì hiện ra 1 form hóa đơn, nhấn ok thì thanh toán, hủy thì quay lại
    /// 
    /// </summary>
}
