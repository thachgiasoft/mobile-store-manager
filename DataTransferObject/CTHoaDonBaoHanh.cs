using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class CTHoaDonBaoHanh
    {
        public CTHoaDonBaoHanh()
        {
            this.matHang = new MatHang();
        }
        private string maCTHoaDonBaoHanh;
        public string MaCTHoaDonBaoHanh
        {
            get { return maCTHoaDonBaoHanh; }
            set { maCTHoaDonBaoHanh = value; }
        }
        private string maHoaDon;
        public string MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }
        private MatHang matHang;
        public MatHang MatHang
        {
            get { return matHang; }
            set { matHang = value; }
        }
        private int soLuong;
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
    }
}
