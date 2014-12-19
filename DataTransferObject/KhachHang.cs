using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class KhachHang
    {
        public KhachHang() {
        }

        private String maKhachHang;
        public String MaKhachHang
        {
            get { return maKhachHang; }
            set { maKhachHang = value; }
        }

        private String tenKhachHang;
        public String TenKhachHang
        {
            get { return tenKhachHang; }
            set { tenKhachHang = value; }
        }


        private String diaChi;
        public String DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        private String soDienThoai;
        public String SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }

        private String email;
        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        private String ghiChu;
        public String GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

    }
}
