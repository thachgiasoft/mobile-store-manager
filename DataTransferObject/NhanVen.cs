using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Ban_DienThoai.DTO
{
   public class NhanVen
    {
       public NhanVen()
       {
       }

        private string maNhanVien;
        public string MaNhanVien
        {
            get
            {
                return this.maNhanVien;
            }
            set
            {
                this.maNhanVien = value;
            }
        }

        private string tenNhanVien;
        public string TrnNhanVien
        {
            get
            {
                return this.tenNhanVien;
            }
            set
            {
                this.tenNhanVien = value;
            }
        }

        private int CMND;
        public int cMND
        {
            get
            {
                return this.cMND;
            }
            set
            {
                this.cMND = value;
            }
        }

        private bool gioiTinh;
        public bool GioiTinh
        {
            get
            {
                return this.gioiTinh;
            }
            set
            {
                this.gioiTinh = value;
            }
        }

        private string diaChi;
        public string DiaChi
        {
            get
            {
                return this.diaChi;
            }
            set
            {
                this.diaChi = value;
            }
        }

        private int soDienThoai;
        public int SoDienThoai
        {
            get
            {
                return this.soDienThoai;
            }
            set
            {
                this.soDienThoai = value;
            }
        }

        private string email;
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        private string ngaySinh;
        public string NgaySinh
        {
            get
            {
                return this.ngaySinh;
            }
            set
            {
                this.ngaySinh = value;
            }
        }

        private string taiKhoan;
        public string TaiKhoan
        {
            get
            {
                return this.taiKhoan;
            }
            set
            {
                this.taiKhoan = value;
            }
        }

        private string matKhau;
        public string MatKhau
        {
            get
            {
                return this.matKhau;
            }
            set
            {
                this.matKhau = value;
            }
        }

        private ChucVu chucVuNhanVien;
        public ChucVu ChucVuNhanVien
        {
            get
            {
                return this.chucVuNhanVien;
            }
            set
            {
                this.chucVuNhanVien = value;
            }
        }

        private string ghiChu;
        public string GhiChu
        {
            get
            {
                return this.ghiChu;
            }
            set
            {
                this.ghiChu = value;
            }
        }
    }
}
