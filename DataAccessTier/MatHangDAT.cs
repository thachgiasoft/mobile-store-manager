using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class MatHangDAT: DataBases
    {
        public DataTable LayDanhSachTenMatHangTheoNhaCungCap(string MaNhaCungCap, int SoLuongToiThieu)
        {
            SqlParameter[] parameter = new SqlParameter[2];
            parameter[0] = new SqlParameter();
            parameter[0].ParameterName = "@p_MaNhaCungCap";
            parameter[0].Value = MaNhaCungCap;
            parameter[1] = new SqlParameter();
            parameter[1].ParameterName = "@p_SoLuongTon";
            parameter[1].Value = SoLuongToiThieu;
            try
            {
                return this.LoadDataTable("CT_NHACUNGCAP_Lst", parameter);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
