using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class NhaSanXuat
    {
        public NhaSanXuat()
        {
        }

        private string maNSX;
        public string MaNSX
        {
            get { return maNSX; }
            set { maNSX = value; }
        }

        private string tenNSX;
        public string TenNSX
        {
            get { return tenNSX; }
            set { tenNSX = value; }
        }

        private string diaChi;
        public string DiaChi
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

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string ghiChu;
        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
    }
}
