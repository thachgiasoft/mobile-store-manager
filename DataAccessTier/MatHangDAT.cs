using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
   public class MatHangDAT : DataBases
    {

       public MatHangDAT()
        {
           
        }

        public DataTable LayDanhSachMatHang()
        {
            try
            {
                return this.LoadDataTable("MATHANG_Lst");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }       
            return null;
        }
    }
}
