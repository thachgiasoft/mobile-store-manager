using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class ChiTietBaoCaoTonKho
    {
        private string thoiGian;

        public string ThoiGian
        {
            get { return thoiGian; }
            set { thoiGian = value; }
        }

        private string maBCTK;

        public string MaBCTK
        {
            get { return maBCTK; }
            set { maBCTK = value; }
        }

        private string tenMatHang;

        public string TenMatHang
        {
            get { return tenMatHang; }
            set { tenMatHang = value; }
        }


        private string maMatHang;

        public string MaMatHang
        {
            get { return maMatHang; }
            set { maMatHang = value; }
        }


        private string nhaCungCap;

        public string NhaCungCap
        {
            get { return nhaCungCap; }
            set { nhaCungCap = value; }
        }

        private int soLuongTon;

        public int SoLuongTon
        {
            get { return soLuongTon; }
            set { soLuongTon = value; }
        }

    }
}
