using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class MauSac
    {

        public MauSac()
       {
       }

        private string maMau;

        public string MaMau
        {
            get { return maMau; }
            set { maMau = value; }
        }
        private string tenMau;

        public string TenMau
        {
            get { return tenMau; }
            set { tenMau = value; }
        }
    }
}
