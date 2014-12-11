using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTier
{
    public class HoaDonNhapHangDAT : DataBases
    {
        public object ThemHoaDonNhapHang(HoaDonNhapHang hd)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[7];
                para[0] = new SqlParameter("@p_MaNhanVien", hd.MaNhanVien);
                para[1] = new SqlParameter("@p_MaTrangThai", hd.MaTinhTrang);
                para[2] = new SqlParameter("@p_TongTien", hd.TongTien);
                para[3] = new SqlParameter("@p_TienDaTT", hd.TienThanhToan);
                para[4] = new SqlParameter("@p_NgayLap", hd.NgayLap);
                para[5] = new SqlParameter("@p_GhiChu", hd.GhiChu);
                para[6] = new SqlParameter("@p_MaHoaDonDatHang", hd.MaHoaDonDatHang);

                return this.LoadDataTable("HOADONNHAPHANG_Ins_l", para).Rows[0].ItemArray[1];
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }

            return false;
        }
    }
}
