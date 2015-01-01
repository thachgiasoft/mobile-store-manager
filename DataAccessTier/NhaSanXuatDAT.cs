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
    public class NhaSanXuatDAT : DataBases
    {
        public NhaSanXuatDAT()
        {
           
        }

        public DataTable LoadComboBox()
        {
            try
            {
                return this.LoadDataTable("NHASANXUAT_Lst");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public string LayTenNhaSanXuat(string maNhaSX)
        {
            string result = "";
            DataTable table;
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@p_MaNhaSanXuat", maNhaSX);

                table = this.LoadDataTable("GetTenNhaSanXuat", para);
                foreach (DataRow row in table.Rows)
                {
                    result = row["TenNSX"].ToString();
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }

            return result;
        }

        public string LayMaNhaSanXuat(string tenNhaSX)
        {
            string result = "";
            DataTable table;
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@p_TenNhaSanXuat", tenNhaSX);

                table = this.LoadDataTable("GetMaNhaSanXuat", para);
                foreach (DataRow row in table.Rows)
                {
                    result = row["MaNSX"].ToString();
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }

            return result;
        }

        public DataTable LayDanhSachNhaSanXuat()
        {
            try
            {
                return this.LoadDataTable("NHASANXUAT_ListNhaSX");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public bool ThemNhaSanXuat(NhaSanXuat nhaSX)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[5];
                para[0] = new SqlParameter("@p_TenNSX", nhaSX.TenNSX);
                para[1] = new SqlParameter("@p_DiaChi", nhaSX.DiaChi);
                para[2] = new SqlParameter("@p_SoDienThoai", nhaSX.SoDienThoai);
                para[3] = new SqlParameter("@p_Email", nhaSX.Email);
                para[4] = new SqlParameter("@p_GhiChu", nhaSX.GhiChu);

                int result = this.ExecuteNonQuery("NHASANXUAT_Ins", para);
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

        public bool CapNhatNhaSanXuat(NhaSanXuat nhaSX)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[6];
                para[0] = new SqlParameter("@p_MaNSX", nhaSX.MaNSX);
                para[1] = new SqlParameter("@p_TenNSX", nhaSX.TenNSX);
                para[2] = new SqlParameter("@p_DiaChi", nhaSX.DiaChi);
                para[3] = new SqlParameter("@p_SoDienThoai", nhaSX.SoDienThoai);
                para[4] = new SqlParameter("@p_Email", nhaSX.Email);
                para[5] = new SqlParameter("@p_GhiChu", nhaSX.GhiChu);

                int result = this.ExecuteNonQuery("NHASANXUAT_Upd", para);
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

        public bool XoaNhaSanXuat(String maNhaSX)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@MaNSX", maNhaSX);

                int result = this.ExecuteNonQuery("NHASANXUAT_Del", para);

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

        public DataTable TimKiemNhaSanXuat(NhaSanXuat nhaSX)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[6];
                para[0] = new SqlParameter("@p_MaNSX", nhaSX.MaNSX);
                para[1] = new SqlParameter("@p_TenNSX", nhaSX.TenNSX);
                para[2] = new SqlParameter("@p_DiaChi", nhaSX.DiaChi);
                para[3] = new SqlParameter("@p_SoDienThoai", nhaSX.SoDienThoai);
                para[4] = new SqlParameter("@p_Email", nhaSX.Email);
                para[5] = new SqlParameter("@p_GhiChu", nhaSX.GhiChu);

                DataTable lstNhaSX = LoadDataTable("NHASANXUAT_Search", para);

                return lstNhaSX;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
