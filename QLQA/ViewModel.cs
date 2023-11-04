using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQA
{
    public class ViewModel
    {
    }
    public class BanAn
    {
        public string MaBan { get; set; }
        public string TenBan { get; set; }
        public bool TrangThai { get; set; } = false;
        public BindingList<MonAnTrongBan>? DanhSachMonAns { get; set; }
    }
    public class MonAnTrongBan
    {
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
    }
    public class MonAn
    {
        public string MaMon { get; set; }
        public string DonGia { get; set; }
    }

    public class MonAnHoaDon
    {
        public int STT { get; set; }
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }
    }
}
