using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class HoaDonNhapHang
    {
        private string maHoaDonNhapHang;

        public string MaHoaDonNhapHang
        {
            get { return maHoaDonNhapHang; }
            set { maHoaDonNhapHang = value; }
        }

        private string maHoaDonDatHang;

        public string MaHoaDonDatHang
        {
            get { return maHoaDonDatHang; }
            set { maHoaDonDatHang = value; }
        }

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

        private DataTable danhSachSanPham;

        public DataTable DanhSachSanPham
        {
            get { return danhSachSanPham; }
            set { danhSachSanPham = value; }
        }

        private string nhaCungCap;

        public string NhaCungCap
        {
            get { return nhaCungCap; }
            set { nhaCungCap = value; }
        }

        private string maTinhTrang;

        public string MaTinhTrang
        {
            get { return maTinhTrang; }
            set { maTinhTrang = value; }
        }

        private double tongTien;

        public double TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }

        private double tienThanhToan;

        public double TienThanhToan
        {
            get { return tienThanhToan; }
            set { tienThanhToan = value; }
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

        private string ngayGiaoHang;

        public string NgayGiaoHang
        {
            get { return ngayGiaoHang; }
            set { ngayGiaoHang = value; }
        }
    }
}
