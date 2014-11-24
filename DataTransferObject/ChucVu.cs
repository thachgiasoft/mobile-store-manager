using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class ChucVu
    {
        public ChucVu()
        {
        }

        private string maChucVu;
        public string MaChucVu
        {
            get
            {
                return this.maChucVu;
            }
            set
            {
                this.maChucVu = value;
            }

        }

        private string tenChucVu;
        public string TenChucVu
        {
            get
            {
                return this.tenChucVu;
            }
            set
            {
                this.tenChucVu = value;
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
