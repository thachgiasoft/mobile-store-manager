using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using DataAccessTier;
using System.Data;

namespace BusinessLogicTier
{
    public class CPUBLT
    {
         private CPUDAT cpuDAT;

         public CPUBLT()
        {
            this.cpuDAT = new CPUDAT();
        }

         public DataTable LoadComBoBox()
         {
             try
             {
                 return this.cpuDAT.LoadComboBox();
             }
             catch (System.Exception ex)
             {
                 Console.WriteLine("Message= {1}", ex.Message);
             }
             return null;
         }

        public DataTable LayDanhSachCPU()
        {
            DataTable data = new DataTable();
            try
            {
                data = this.cpuDAT.LayDanhSachCPU();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    // data.Rows[i].
                }
                return data;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public bool ThemCPU(CPU cpu)
        {
            try
            {
                return this.cpuDAT.ThemCPU(cpu);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhatCPU(CPU cpu)
        {

            try
            {
                return this.cpuDAT.CapNhatCPU(cpu);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool XoaCPU(String maCPU)
        {

            try
            {
                return this.cpuDAT.XoaCPU(maCPU);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public DataTable TimKiemCPU(CPU cpu)
        {
            try
            {
                return this.cpuDAT.TimKiemCPU(cpu);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
