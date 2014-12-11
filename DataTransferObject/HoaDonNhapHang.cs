using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class HoaDonNhapHang : HoaDon
    {
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

    }
}
