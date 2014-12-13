using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
   public class ChucVuDAT : DataBases
    {
       public ChucVuDAT()
        {
           
        }

       public DataTable LoadComboBox()
        {
            try
            {
                return this.LoadDataTable("CHUCVU_Lst");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }       
            return null;
        }
    }
}
