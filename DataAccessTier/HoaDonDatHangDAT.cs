using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessTier
{
    public class HoaDonDatHangDAT : DataBases
    {
        public object ThemHoaDonDatHang(HoaDonDatHang hd)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[8];
                para[0] = new SqlParameter("@p_MaNhanVien", hd.MaNhanVien);
                para[1] = new SqlParameter("@p_MaTrangThai", hd.MaTinhTrang);
                para[2] = new SqlParameter("@p_TongTien", hd.TongTien);
                para[3] = new SqlParameter("@p_TienDaTT", hd.TienThanhToan);
                para[4] = new SqlParameter("@p_NgayLap", hd.NgayLap);
                para[5] = new SqlParameter("@p_MaNhaCungCaphd", hd.MaNhaCungCap);
                para[6] = new SqlParameter("@p_NgayGiaoHanghd", hd.NgayGiaoHang);
                para[7] = new SqlParameter("@p_GhiChu", hd.GhiChu);
                return this.LoadDataTable("HOADONDATHANG_Ins_l", para).Rows[0].ItemArray[1];
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }

            return false;
        }
    }
}
