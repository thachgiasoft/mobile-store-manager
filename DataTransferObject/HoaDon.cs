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


        private TrangThai trangThai;
        public TrangThai TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        private decimal tienDaTT;
        public decimal TienDaTT
        {
            get { return tienDaTT; }
            set { tienDaTT = value; }
        }

       private string maHoaDon;
        public string MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }

        private LoaiHoaDon loaiHoaDon;
        public LoaiHoaDon LoaiHoaDon
        {
            get { return loaiHoaDon; }
            set { LoaiHoaDon = value; }
        }

        private MatHang matHang;
        public MatHang MatHang
        {
            get { return matHang; }
            set { matHang = value; }
        }

        private NhanVien nhanVien;
        public NhanVien NhanVien
        {
            get { return nhanVien; }
            set { nhanVien = value; }
        }

        private int soLuong;
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        private string layLap;
        public string LayLap
        {
            get { return layLap; }
            set { layLap = value; }
        }

        private decimal tongTien;

        public decimal TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }

        private float tienThanhToan;

        public float TienThanhToan
        {
            get { return tienThanhToan; }
            set { tienThanhToan = value; }
        }

        private float tienNo;

        public float TienNo
        {
            get { return tienNo; }
            set { tienNo = value; }
        }

        private string maTinhTrang;

        public string MaTinhTrang
        {
            get { return maTinhTrang; }
            set { maTinhTrang = value; }
        }

        private string ngayGiaoHang;

        public string NgayGiaoHang
        {
            get { return ngayGiaoHang; }
            set { ngayGiaoHang = value; }
        }

        private string ngayLap;

        public string NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }

        private string ghiChu;
        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
    }
}
