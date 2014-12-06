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

        private string ghiChu;
        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
    }
}
