using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class MatHang
    {
        public MatHang()
        { this.hinhAnh = new HinhAnh();}
        private string maMatHang;
        public string MaMatHang
        {
            get { return maMatHang; }
            set { maMatHang = value; }
        }

        private string tenMatHang;
        public string TenMatHang
        {
            get { return tenMatHang; }
            set { tenMatHang = value; }
        }

        private string maloaiMatHang;
        public string MaLoaiMatHang
        {
            get { return maloaiMatHang; }
            set { maloaiMatHang = value; }
        }
       

        private string maNhaSanXuat;
        public string MaNhaSanXuat
        {
            get { return maNhaSanXuat; }
            set { maNhaSanXuat = value; }
        }
       

        private int soLuong;
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        private int thoiGianBaoHanh;
        public int ThoiGianBaoHanh
        {
            get { return thoiGianBaoHanh; }
            set { thoiGianBaoHanh = value; }
        }

        private string moTa;
        public string MoTa
        {
            get { return moTa; }
            set { moTa = value; }
        }

        private string ghiChu;
        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        private HinhAnh hinhAnh;
        public HinhAnh HinhAnh 
        {
            get { return hinhAnh; }
            set { hinhAnh = value; }
        }

        private string maNhaCungCap;

        public string MaNhaCungCap
        {
            get { return maNhaCungCap; }
            set { maNhaCungCap = value; }
        }
    }
}
