using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Ban_DienThoai.DTO
{
    public class NhaCungCap
    {
        public NhaCungCap() { }

        private String maNhaCungCap;
        public String MaNhaCungCap
        {
            get { return maNhaCungCap; }
            set { maNhaCungCap = value; }
        }

        private String tenNhaCungCap;
        public String TenNhaCungCap
        {
            get { return tenNhaCungCap; }
            set { tenNhaCungCap = value; }
        }

        private String diaChi;
        public String DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        private int soDienThoai;
        public int SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }

        private String web;
        public String Web
        {
            get { return web; }
            set { web = value; }
        }
    }
}
