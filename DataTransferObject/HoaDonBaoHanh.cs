using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class HoaDonBaoHanh
    {
        public HoaDonBaoHanh() 
        {
            this.hoaDon = new HoaDon();
            this.hoaDonBan = new HoaDonBan();
            this.khachHang = new KhachHang();
            this.ctHoaDonBH = new CTHoaDonBaoHanh();
        }

        private HoaDon hoaDon;
        public HoaDon HoaDon
        {
            get { return hoaDon; }
            set { hoaDon = value; }
        }

        private HoaDonBan hoaDonBan;
        public HoaDonBan HoaDonBan
        {
            get { return hoaDonBan; }
            set { hoaDonBan = value; }
        }

        private CTHoaDonBaoHanh ctHoaDonBH;
        public CTHoaDonBaoHanh CtHoaDonBH
        {
            get { return ctHoaDonBH; }
            set { ctHoaDonBH = value; }
        }

        private KhachHang khachHang;
        public KhachHang KhachHang
        {
            get { return khachHang; }
            set { khachHang = value; }
        }

        private String maHoaDonBaoHanh;
        public String MaHoaDonBaoHanh
        {
            get { return maHoaDonBaoHanh; }
            set { maHoaDonBaoHanh = value; }
        }

       

        
    }
}
