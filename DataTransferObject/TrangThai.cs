using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class TrangThai
    {
        private String maTrangThai;
        public String MaTrangThai
        {
            get { return maTrangThai; }
            set { maTrangThai = value; }
        }

        private String tenTrangThai;
        public String TenTrangThai
        {
            get { return tenTrangThai; }
            set { tenTrangThai = value; }
        }

        private String ghiChu;
        public String GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
    }
}
