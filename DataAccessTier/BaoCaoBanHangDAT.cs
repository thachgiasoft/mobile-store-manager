using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class BaoCaoBanHangDAT : DataBases
    {
        public BaoCaoBanHangDAT()
        {
        }

        public DataTable BaoCaoBanHang(String  tuNgay, String denNgay)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[2];
                para[0] = new SqlParameter("@p_TuNgay", tuNgay == "" ? null : tuNgay);
                para[1] = new SqlParameter("@p_DenNgay", denNgay == "" ? "" : denNgay);

                return this.LoadDataTable("BAOCAOBANHANG", para);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
