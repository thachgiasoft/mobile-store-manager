using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class BaoCaoNhapHangDAT : DataBases
    {
        public DataTable LayChiTietBaoCao(BaoCaoNhapHang bc)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@p_ThoiGian", bc.ThoiGian);

                return this.LoadDataTable("CHITIETBAOCAONHAPHANG_List", para);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
