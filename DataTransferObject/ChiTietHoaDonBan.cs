using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class ChiTietHoaDonBan
    {
        public ChiTietHoaDonBan()
        { }

        private string maHoaDon;
        public string MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }

        private KhachHang khachHang;
        public KhachHang KhachHang
        {
            get { return KhachHang; }
            set { KhachHang = value; }
        }

        private HoaDon ctHoaDon;
        public HoaDon CtHoaDon
        {
            get { return ctHoaDon; }
            set { ctHoaDon = value; }
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

        private decimal tienDaTT;
        public decimal TienDaTT
        {
            get { return tienDaTT; }
            set { tienDaTT = value; }
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
