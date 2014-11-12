using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Ban_DienThoai.DTO
{
    public class HoaDonBan
    {
        public HoaDonBan()
        { }

        private string maHoaDon;
        public string MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }

        private string maKhachHang;
        public string MaKhachHang
        {
            get { return maKhachHang; }
            set { maKhachHang = value; }
        }

        private bool trangThai;
        public bool TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        private decimal tongTien;
        public decimal TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }

        private decimal tienNo;
        public decimal TienNo
        {
            get { return tienNo; }
            set { tienNo = value; }
        }

        private string ngayTT;
        public string NgayTT
        {
            get { return ngayTT; }
            set { ngayTT = value; }
        }
    }
}
