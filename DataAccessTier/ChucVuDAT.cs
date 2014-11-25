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

       public DataSet LoadComboBox()
        {
            try
            {
                return this.LoadComBox("CHUCVU_Lst");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }       
            return null;
        }
    }
}
