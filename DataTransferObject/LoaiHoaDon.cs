using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class LoaiHoaDon
    {
        public LoaiHoaDon()
        {
        }

        private string maLoaiHoaDon;
        public string MaLoaiHoaDon
        {
            get { return maLoaiHoaDon; }
            set { maLoaiHoaDon = value; }
        }

        private string tenLoaiHoaDon;
        public string TenLoaiHoaDon
        {
            get { return tenLoaiHoaDon; }
            set { tenLoaiHoaDon = value; }
        }

        private string moTa;
        public string MoTa
        {
            get { return moTa; }
            set { moTa = value; }
        }

        private string ghiChu;
        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
    }
}
