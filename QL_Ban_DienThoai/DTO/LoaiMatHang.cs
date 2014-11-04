using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Ban_DienThoai.DTO
{
    public class LoaiMatHang
    {
        public LoaiMatHang()
        {
        }

        private string maoLaiMatHang;
        public string MaoLaiMatHang
        {
            get { return maoLaiMatHang; }
            set { maoLaiMatHang = value; }
        }

        private string tenLoaiMatHang;
        public string TenLoaiMatHang
        {
            get { return tenLoaiMatHang; }
            set { tenLoaiMatHang = value; }
        }

        private string dacDiem;
        public string DacDiem
        {
            get { return dacDiem; }
            set { dacDiem = value; }
        }

        private string ghiChu;
        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
    }
}
