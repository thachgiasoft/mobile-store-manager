using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class ChiTietNhaCungCap
    {
        private string maMatHang;

        public string MaMatHang
        {
            get { return maMatHang; }
            set { maMatHang = value; }
        }
        private string maNhaCungCap;

        public string MaNhaCungCap
        {
            get { return maNhaCungCap; }
            set { maNhaCungCap = value; }
        }
        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
        private string maDonGia;

        public string MaDonGia
        {
            get { return maDonGia; }
            set { maDonGia = value; }
        }
    }
}
