using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataTransferObject
{
    public class HoaDonDatHang
    {
        private string maNhanVien;

        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        private string tenNhanVien;

        public string TenNhanVien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }

        private double tongTien;

        public double TongTien
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
        private string maNhaCungCap;

        public string MaNhaCungCap
        {
            get { return maNhaCungCap; }
            set { maNhaCungCap = value; }
        }

        private string nhaCungCap;

        public string NhaCungCap
        {
            get { return nhaCungCap; }
            set { nhaCungCap = value; }
        }

        private DataTable  danhSachSanPham;

        public DataTable DanhSachSanPham
        {
            get { return danhSachSanPham; }
            set { danhSachSanPham = value; }
        }

        private string maHoaDon;

        public string MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }
    }
}
