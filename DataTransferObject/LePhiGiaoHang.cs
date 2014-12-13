using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class LePhiGiaoHang
    {
        private String maKhuVuc;
        public String MaKhuVuc
        {
            get { return maKhuVuc; }
            set { maKhuVuc = value; }
        }

        private String tenKhuVuc;
        public String TenKhuVuc
        {
            get { return tenKhuVuc; }
            set { tenKhuVuc = value; }
        }

        private Decimal dongia;
        public Decimal Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }

    }
}
