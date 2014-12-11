using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class ChiTietHoaDonNhapHangDAT: DataBases
    {
        public bool ThemChiTietHoaDonNhapHang(ChiTietHoaDonNhapHang ctnh)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[3];
                para[0] = new SqlParameter("@p_MaHoaDonNhap", ctnh.MaHoaDonNhapHang);
                para[1] = new SqlParameter("@p_MaMatHang", ctnh.MaMatHang);
                para[2] = new SqlParameter("@p_SoLuong", ctnh.SoLuong);
                int result = this.ExecuteNonQuery("CT_HOADONNHAPHANG_Ins", para);
                if (result == 1)
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
    }
}
