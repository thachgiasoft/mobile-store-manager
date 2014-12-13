using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public DataTable LayDanhSachTenMatHangTheoNhaCungCap(string MaNhaCungCap, int SoLuongToiThieu)
        {
            SqlParameter[] para = new SqlParameter[2];
            para[0] = new SqlParameter("@p_MaNhaCungCap", MaNhaCungCap);
            para[1] = new SqlParameter("@p_SoLuongTon", SoLuongToiThieu);
            try
            {
                return this.LoadDataTable("CT_NHACUNGCAP_Lst", para);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable LayMaMatHang(string tenmathang)
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@p_TenMatHang", tenmathang);
            try
            {
                return this.LoadDataTable("MATHANG_Lst_LayMaMatHang", para);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
