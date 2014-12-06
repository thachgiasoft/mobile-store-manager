using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class ChiTietHoaDonBaoHanh
    {
        public ChiTietHoaDonBaoHanh() { }

        private String maHoaDonBaoHanh;
        public String MaHoaDonBaoHanh
        {
            get { return maHoaDonBaoHanh; }
            set { maHoaDonBaoHanh = value; }
        }

        private KhachHang khachHang;
        public KhachHang KhachHang
        {
            get { return khachHang; }
            set { khachHang = value; }
        }

        private DateTime ngayBatDau;
        public DateTime NgayBatDau
        {
            get { return ngayBatDau; }
            set { ngayBatDau = value; }
        }

        private DateTime ngayKetThuc;
        public DateTime NgayKetThuc
        {
            get { return ngayKetThuc; }
            set { ngayKetThuc = value; }
        }
    }
}
