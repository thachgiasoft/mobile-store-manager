using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using System.Data.SqlClient;

namespace DataAccessTier
{
    public class ChiTietHoaDonDatHangDAT : DataBases
    {
        public bool ThemChiTietHoaDonDatHang(ChiTietHoaDonDatHang cthd)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[2];
                para[0] = new SqlParameter("@p_MaNhanVien", cthd.MaMatHang);
                para[1] = new SqlParameter("@p_TongTien", cthd.NhaCungCap);

                int result = this.ExecuteNonQuery("HOADON_Ins", para);
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
