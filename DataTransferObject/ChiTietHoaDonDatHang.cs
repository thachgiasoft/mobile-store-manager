using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class ChiTietHoaDonDatHang
    {
        public ChiTietHoaDonDatHang() { }

        private String maHoaDonDatHang;
        public String MaHoaDonDatHang
        {
            get { return maHoaDonDatHang; }
            set { maHoaDonDatHang = value; }
        }

        private DateTime ngayDatHang;
        public DateTime NgayDatHang
        {
            get { return ngayDatHang; }
            set { ngayDatHang = value; }
        }

        private DateTime ngayGiaoHang;
        public DateTime NgayGiaoHang
        {
            get { return ngayGiaoHang; }
            set { ngayGiaoHang = value; }
        }

        private NhaCungCap nhaCungCap;
        public NhaCungCap NhaCungCap
        {
            get { return nhaCungCap; }
            set { nhaCungCap = value; }
        }

        private int tinhTrang;
        public int TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }

        private Decimal tongGia;
        public Decimal TongGia
        {
            get { return tongGia; }
            set { tongGia = value; }
        }

        private String ghiChu;
        public String GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
    }
}
