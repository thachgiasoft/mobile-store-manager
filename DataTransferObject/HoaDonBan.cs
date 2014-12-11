using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class HoaDonBan
    {
        public HoaDonBan()
        {
            this.KhachHang = new KhachHang();
            this.hoaDon = new HoaDon();
            this.CtHoaDon = new CTHoaDonBan();
            this.lePhiGiaoHang = new LePhiGiaoHang();
        }

        private HoaDon hoaDon;
        public HoaDon HoaDon
        {
            get { return hoaDon; }
            set { hoaDon = value; }
        }

        private KhachHang khachHang;
        public KhachHang KhachHang
        {
            get { return khachHang; }
            set { khachHang = value; }
        }

        private CTHoaDonBan ctHoaDon;
        public CTHoaDonBan CtHoaDon
        {
            get { return ctHoaDon; }
            set { ctHoaDon = value; }
        }
      
        private String diaChiGH;
        public String DiaChiGH
        {
            get { return diaChiGH; }
            set { diaChiGH = value; }
        }

        private LePhiGiaoHang lePhiGiaoHang;
        public LePhiGiaoHang LePhiGiaoHang
        {
            get { return lePhiGiaoHang; }
            set { lePhiGiaoHang = value; }
        }
      
        private String ngayGiaoHang;
        public String NgayGiaoHang
        {
            get { return ngayGiaoHang; }
            set { ngayGiaoHang = value; }
        }

        private String ngayTT;
        public String NgayTT
        {
            get { return ngayTT; }
            set { ngayTT = value; }
        }
    }
}
