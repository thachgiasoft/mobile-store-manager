using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class ChiTietHoaDonNhapHang
    {
        public ChiTietHoaDonNhapHang() { }

        private string maHoaDonNhapHang;
        public string MaHoaDonNhapHang
        {
            get { return maHoaDonNhapHang; }
            set { maHoaDonNhapHang = value; }
        }

        private string maMatHang;

        public string MaMatHang
        {
            get { return maMatHang; }
            set { maMatHang = value; }
        }

        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
    }
}
