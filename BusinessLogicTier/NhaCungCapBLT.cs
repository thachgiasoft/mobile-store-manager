using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;
using System.Data;

namespace BusinessLogicTier
{
   public  class NhaCungCapBLT
    {
        NhaCungCapDAT _NhaCungCapDAT;

        public NhaCungCapBLT()
        {
            this._NhaCungCapDAT = new NhaCungCapDAT();
        }

        public DataTable layDanhSachNhaCungCap()
        {
            DataTable data = new DataTable();
            try
            {
                data = this._NhaCungCapDAT.layDanhSachNhaCungCap();
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
    }
}
