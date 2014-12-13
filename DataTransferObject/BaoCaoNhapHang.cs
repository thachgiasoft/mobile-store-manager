using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class BaoCaoNhapHang
    {
        private string thoiGian;

        public string ThoiGian
        {
            get { return thoiGian; }
            set { thoiGian = value; }
        }

        private DataTable chiTietBaoCao;

        public DataTable ChiTietBaoCao
        {
            get { return chiTietBaoCao; }
            set { chiTietBaoCao = value; }
        }
    }
}
