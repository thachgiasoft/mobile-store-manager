using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
   public class HoaDon
    {
       public HoaDon()
       {
           this.nhanVien = new NhanVien();
           this.trangThai = new TrangThai();
       }
        private string maHoaDon;
        public string MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }

        private NhanVien nhanVien;
        public NhanVien NhanVien
        {
            get { return nhanVien; }
            set { nhanVien = value; }
        }

        private TrangThai trangThai;
        public TrangThai TrangThai
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

        private String ngayLap;
        public String NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }

        private String ghiChu;
        public String GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

    }
}
