using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class LoaiMatHang
    {
        public LoaiMatHang()
        {
        }

        private string maLoaiMatHang;
        public string MaLoaiMatHang
        {
            get { return maLoaiMatHang; }
            set { maLoaiMatHang = value; }
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
