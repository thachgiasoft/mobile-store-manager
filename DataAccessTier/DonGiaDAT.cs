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
    public class DonGiaDAT: DataBases
    {
        public DonGiaDAT()
        {
           
        }

        public DataTable LayDanhSachDonGia()
        {
            try
            {
                return this.LoadDataTable("DONGIA_ListDONGIA");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public bool ThemDonGia(DonGia donGia)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[2];
                para[0] = new SqlParameter("@p_GiaNhap", donGia.GiaNhap);
                para[1] = new SqlParameter("@p_GiaXuat", donGia.GiaXuat);

                int result = this.ExecuteNonQuery("DONGIA_Ins", para);
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

        public bool CapNhatDonGia(DonGia donGia)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[3];
                para[0] = new SqlParameter("@p_MaDonGia", donGia.MaDonGia);
                para[1] = new SqlParameter("@p_GiaNhap", donGia.GiaNhap);
                para[2] = new SqlParameter("@p_GiaXuat", donGia.GiaXuat);

                int result = this.ExecuteNonQuery("DONGIA_Upd", para);
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

        public bool XoaDonGia(String maDonGia)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@MaDonGia", maDonGia);
                int result = this.ExecuteNonQuery("DONGIA_Del", para);

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

        public DataTable TimKiemDonGia(DonGia donGia)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[3];
                para[0] = new SqlParameter("@p_MaDonGia", donGia.MaDonGia);
                para[1] = new SqlParameter("@p_GiaNhap", donGia.GiaNhap);
                para[2] = new SqlParameter("@p_GiaXuat", donGia.GiaXuat);

                DataTable lstDonGia = LoadDataTable("DONGIA_Search", para);

                return lstDonGia;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable LayDonGiaBangMaSanPham(string maSP)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@p_MaSanPham", maSP);


                DataTable dg = LoadDataTable("DONGIA_GetByMaSanPham", para);
                return dg;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable LayMaDonGiaBangMaSanPham(DonGia dongia)
        { 
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@p_MaMatHang", dongia.MaMatHang);
                DataTable dg = LoadDataTable("LayMaDonGia_L", para);
                return dg;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        //them don gia voi gia tri tra ve la ma don gia
        public string ThemDonGiaVaLayMaDonGia(DonGia donGia)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[2];
                para[0] = new SqlParameter("@p_GiaNhap", donGia.GiaNhap);
                para[1] = new SqlParameter("@p_GiaXuat", donGia.GiaXuat);

                DataTable dt = this.LoadDataTable("DONGIA_Ins", para);
                if (dt != null)
                {
                    return dt.Rows[0].ItemArray[1].ToString();
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }

            return null;
        }
    }
}
