using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class ThamSo
    {
        public ThamSo()
        {
        }


        private String tenThamSo;
        public String TenThamSo
        {
            get { return tenThamSo; }
            set { tenThamSo = value; }
        }

        private String giaTriChuoi;
        public String GiaTriChuoi
        {
            get { return giaTriChuoi; }
            set { giaTriChuoi = value; }
        }

        private decimal giaTriSo;
        public decimal GiaTriSo
        {
            get { return giaTriSo; }
            set { giaTriSo = value; }
        }
    }
}
