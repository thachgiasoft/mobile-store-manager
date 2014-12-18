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
    public class MauSacDAT : DataBases
    {
        public MauSacDAT()
        {
           
        }

        public DataTable LoadComboBox()
        {
            try
            {
                return this.LoadDataTable("MAUMATHANG_Lst");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable LayDanhSachMauSac()
        {
            try
            {
                return this.LoadDataTable("MAUMATHANG_ListMAUMH");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public bool ThemMauSac(MauSac ms)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@p_TenMau", ms.TenMau);

                int result = this.ExecuteNonQuery("MAUMATHANG_Ins", para);
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

        public bool CapNhatMauSac(MauSac ms)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[2];
                para[0] = new SqlParameter("@p_MaMau", ms.MaMau);
                para[1] = new SqlParameter("@p_TenMau", ms.TenMau);

                int result = this.ExecuteNonQuery("MAUMATHANG_Upd", para);
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

        public bool XoaMauSac(String maMau)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@MaMau", maMau);
                int result = this.ExecuteNonQuery("MAUMATHANG_Del", para);

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
        public DataTable TimKiemMauSac(MauSac ms)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[2];
                para[0] = new SqlParameter("@p_MaMau", ms.MaMau);
                para[1] = new SqlParameter("@p_TenMau", ms.TenMau);

                DataTable lstMauSac = LoadDataTable("MAUMATHANG_Search", para);
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
