using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Ban_DienThoai.DTO
{
    public class DonGia
    {
        public DonGia()
        {
        }

        private string maDonGia;
        public string MaDonGia
        {
            get { return maDonGia; }
            set { maDonGia = value; }
        }

        private decimal giaNhap;
        public decimal GiaNhap
        {
            get { return giaNhap; }
            set { giaNhap = value; }
        }

        private decimal giaXuat;
        public decimal GiaXuat
        {
            get { return giaXuat; }
            set { giaXuat = value; }
        }
    }
}
