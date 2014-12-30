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
    public class ThamSoDAT : DataBases
    {
        public bool SuaThamSo(ThamSo thamso)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[3];
                para[0] = new SqlParameter("@p_TenThamSo", thamso.TenThamSo);
                para[1] = new SqlParameter("@p_GiaTriChuoi", thamso.GiaTriChuoi);
                para[2] = new SqlParameter("@p_GiaTriSo", thamso.GiaTriSo);
                int result = this.ExecuteNonQuery("THAMSO_Upd", para);
                if (result != 0)
                {
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }
        public string LayGiaTriThamSo(ThamSo thamso)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@p_TenThamSo", thamso.TenThamSo);
                DataTable dt = this.LoadDataTable("THAMSO_Lst", para);
                if (dt.Rows.Count > 0)
                    return dt.Rows[0].ItemArray[2].ToString();
                return null;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
