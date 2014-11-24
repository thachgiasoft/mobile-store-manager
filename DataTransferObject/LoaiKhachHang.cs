using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class LoaiKhachHang
    {
        public LoaiKhachHang() { }

        private String maLoaiKhachHang;
        public String MaLoaiKhachHang
        {
            get { return maLoaiKhachHang; }
            set { maLoaiKhachHang = value; }
        }

        private String tenLoaiKhachHang;
        public String TenLoaiKhachHang
        {
            get { return tenLoaiKhachHang; }
            set { tenLoaiKhachHang = value; }
        }

        private String ghiChu;
        public String GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
    }
}
