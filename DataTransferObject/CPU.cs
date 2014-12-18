using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class CPU
    {
       public CPU()
       {
       }

       private string maCPU;

       public string MaCPU
       {
           get { return maCPU; }
           set { maCPU = value; }
       }
       private string tenCPU;

       public string TenCPU
       {
           get { return tenCPU; }
           set { tenCPU = value; }
       }
       private int sonhanCPU;

       public int SonhanCPU
       {
           get { return sonhanCPU; }
           set { sonhanCPU = value; }
       }
    }
}
