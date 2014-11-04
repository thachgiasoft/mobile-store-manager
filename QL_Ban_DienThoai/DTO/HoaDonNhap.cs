using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Ban_DienThoai.DTO
{
    public class HoaDonNhap
    {
        public HoaDonNhap() { }

        private String maHoaDon;
        public String MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }

        private Decimal tongTien;
        public Decimal TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }

        private Decimal tienDaTT;
        public Decimal TienDaTT
        {
            get { return tienDaTT; }
            set { tienDaTT = value; }
        }

        private Decimal tienNo;
        public Decimal TienNo
        {
            get { return tienNo; }
            set { tienNo = value; }
        }

        private DateTime ngayTT;
        public DateTime NgayTT
        {
            get { return ngayTT; }
            set { ngayTT = value; }
        }
    }
}
