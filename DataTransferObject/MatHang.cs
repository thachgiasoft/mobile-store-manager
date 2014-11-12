using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Ban_DienThoai.DTO
{
    public class MatHang
    {
        public MatHang()
        { }
        private string maMatHang;
        public string MaMatHang
        {
            get { return maMatHang; }
            set { maMatHang = value; }
        }

        private string tenMatHagn;
        public string TenMatHagn
        {
            get { return tenMatHagn; }
            set { tenMatHagn = value; }
        }

        private LoaiMatHang loaiMatHang;
        public LoaiMatHang LoaiMatHang
        {
            get { return loaiMatHang; }
            set { loaiMatHang = value; }
        }

        private NhaSanXuat nhanSanXuat;
        public NhaSanXuat NhanSanXuat
        {
            get { return nhanSanXuat; }
            set { nhanSanXuat = value; }
        }

        private int soLuong;
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        private DonGia donGia;
        public DonGia DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        private string ngaySanXuat;
        public string NgaySanXuat
        {
            get { return ngaySanXuat; }
            set { ngaySanXuat = value; }
        }

        private string ngayKetThuc;
        public string NgayKetThuc
        {
            get { return ngayKetThuc; }
            set { ngayKetThuc = value; }
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
     
    }
}
