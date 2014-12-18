using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class NhaCungCapDAT : DataBases
    {
        public DataTable layDanhSachNhaCungCap()
        {
            try
            {
                return this.LoadDataTable("NHACUNGCAP_Lst");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
