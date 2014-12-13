using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class BaoCaoTonKhoDAT : DataBases
    {
        public object LapBaoCao(string thoigian)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@p_ThoiGian", thoigian);

                return this.LoadDataTable("BAOCAOTONKHO_Ins", para).Rows[0].ItemArray[1];
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public DataTable LayDanhSachBaoCao()
        { 
            try
            {
                return this.LoadDataTable("DANHSACHBAOCAOTONKHO_Lst");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable LayBaoCaoTheoThoiGian(string thoigian)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@p_ThoiGian", thoigian);
                return this.LoadDataTable("DANHSACHBAOCAOTONKHO_Lst_theothoigian");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
