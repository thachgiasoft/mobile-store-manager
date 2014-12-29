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
    public class HinhAnhDAT : DataBases
    {
        public bool ThemHinhAnh(HinhAnh hinhanh)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[2];
                para[0] = new SqlParameter("@p_MaMatHang", hinhanh.MaSanPham);
                para[1] = new SqlParameter("@p_NoiDung", hinhanh.NoiDungHinhAnh);
                int result = this.ExecuteNonQuery("HINHANHMATHANG_Ins", para);
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
        public bool XoaHinhAnh(HinhAnh hinhanh)
        {
            
            return false;
        }

        public DataTable LayHinhAnhMoiNhat()
        { 
            try
            {
                return this.LoadDataTable("HINHANHMATHANG_Lst_lastest");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
