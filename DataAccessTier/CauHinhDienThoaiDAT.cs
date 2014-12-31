using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessTier;
using DataTransferObject;
using System.Data.SqlClient;

namespace DataAccessTier
{
    public class CauHinhDienThoaiDAT : DataBases
    {
        public CauHinhDienThoaiDAT()
        {
           
        }

        public DataTable LayCauHinhByMaMatHang(string maMatHang)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@p_MaSanPham", maMatHang);


                DataTable lstMauSac = LoadDataTable("GetCauHinhByMaSanPham", para);
                return lstMauSac;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

    }
}
