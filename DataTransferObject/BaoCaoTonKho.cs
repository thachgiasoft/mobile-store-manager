using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class BaoCaoTonKho
    {
        private DataTable danhSachSanPham;

        public DataTable DanhSachSanPham
        {
            get { return danhSachSanPham; }
            set { danhSachSanPham = value; }
        }

        private string thoiGian;

        public string ThoiGian
        {
            get { return thoiGian; }
            set { thoiGian = value; }
        }

    }
}
