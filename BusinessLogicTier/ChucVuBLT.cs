using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using System.Data;

namespace BusinessLogicTier
{
   public class ChucVuBLT
    {
        private ChucVuDAT chucVuDAT;

        public ChucVuBLT()
        {
            this.chucVuDAT = new ChucVuDAT();
        }

        public DataTable LoadComBoBox()
        {          
            try
            {
                return this.chucVuDAT.LoadComboBox();              
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
