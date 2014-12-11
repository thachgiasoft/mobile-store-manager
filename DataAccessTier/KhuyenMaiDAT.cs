using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessTier
{
   public class KhuyenMaiDAT : DataBases
    {
       public KhuyenMaiDAT()
        {
           
        }

        public DataTable LayDanhSachCTKhuyenMai()
        {
            try
            {
                return this.LoadDataTable("CHUONGTRINH_KHUYENMAI_Lst");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }       
            return null;
        }

        public DataTable LayDanhSachChiTietKhuyenMai()
        {
            try
            {
                return this.LoadDataTable("CT_KHUYENMAI_Lst");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public bool ThemCTKhuyenMai(KhuyenMai km, XElement xml)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[5];
                para[0] = new SqlParameter("@p_TenKhuyenMai", km.TenChuongTrinh == null ? "" : km.TenChuongTrinh);
                para[1] = new SqlParameter("@p_ThoiGianBD", km.ThoiGianDB == null ? DateTime.Now.ToString("dd/MM/yyyy") : km.ThoiGianDB);
                para[2] = new SqlParameter("@p_ThoiGianKT", km.ThoiGianKT == null ? DateTime.Now.ToString("dd/MM/yyyy") : km.ThoiGianKT);
                para[3] = new SqlParameter("@p_GhiChu", km.GhiChu == null ? "" : km.GhiChu);

                para[4] = new SqlParameter();
                para[4].ParameterName = "@p_XML_TEMP";
                para[4].DbType = DbType.Xml;
                para[4].Direction = ParameterDirection.Input;
                para[4].Value = xml.ToString();

                int result = this.ExecuteNonQuery("CHUONGTRINH_KHUYENMAI_Ins", para);
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

        public bool CapNhatCTKhuyenMai(KhuyenMai km, XElement xml)
        {
              try
              {
                  SqlParameter[] para = new SqlParameter[6];
                  para[0] = new SqlParameter("@p_MaKhuyenMai", km.MaKhuyenMai == null ? "" : km.MaKhuyenMai);
                  para[1] = new SqlParameter("@p_TenKhuyenMai", km.TenChuongTrinh == null ? "" : km.TenChuongTrinh);
                  para[2] = new SqlParameter("@p_ThoiGianBD", km.ThoiGianDB == null ? DateTime.Now.ToString("dd/MM/yyyy") : km.ThoiGianDB);
                  para[3] = new SqlParameter("@p_ThoiGianKT", km.ThoiGianKT == null ? DateTime.Now.ToString("dd/MM/yyyy") : km.ThoiGianKT);
                  para[4] = new SqlParameter("@p_GhiChu", km.GhiChu == null ? "" : km.GhiChu);

                  para[5] = new SqlParameter();
                  para[5].ParameterName = "@p_XML_TEMP";
                  para[5].DbType = DbType.Xml;
                  para[5].Direction = ParameterDirection.Input;
                  para[5].Value = xml.ToString();

                  int result = this.ExecuteNonQuery("CHUONGTRINH_KHUYENMAI_Upd", para);
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

        public bool CapNhatCTSoLuongKhuyenMai(CTKHuyenMai km)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[3];
                para[0] = new SqlParameter("@p_MaKhuyenMai", km.KhuyenMai.MaKhuyenMai == null ? "" : km.KhuyenMai.MaKhuyenMai);             
                para[1] = new SqlParameter("@p_MaMatHang", km.MatHang.MaMatHang == null ? "" : km.MatHang.MaMatHang);
                para[2] = new SqlParameter("@p_SoLuong", km.SoLuong == null ? 0 : km.SoLuong);

                int result = this.ExecuteNonQuery("CT_KHUYENMAI_UpdCount", para);
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

        public bool XoaCTKhuyenMai(String maKhuyenMai)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@MaKhuyenMai", maKhuyenMai);
                int result = this.ExecuteNonQuery("CHUONGTRINH_KHUYENMAI_Del", para);

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

        public DataTable TimKiemCTKhuyenMai(KhuyenMai km)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[6];
                para[0] = new SqlParameter("@p_MaKhuyenMai", km.MaKhuyenMai == null ? "" : km.MaKhuyenMai);
                para[1] = new SqlParameter("@p_TenKhuyenMai", km.TenChuongTrinh == null ? "" : km.TenChuongTrinh);
                para[2] = new SqlParameter("@p_ThoiGianBD", km.ThoiGianDB == null ? "" : km.ThoiGianDB);
                para[3] = new SqlParameter("@p_ThoiGianKT", km.ThoiGianKT == null ? "" : km.ThoiGianKT);
                para[4] = new SqlParameter("@p_GhiChu", km.GhiChu == null ? "" : km.GhiChu);
                para[5] = new SqlParameter("@p_TOP", 100);
                DataTable lstKhuyenMai = LoadDataTable("CHUONGTRINH_KHUYENMAI_Search", para);

                return lstKhuyenMai;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }    
            return null;
        }

        public DataTable TimKiemChiTietKhuyenMai(CTKHuyenMai km)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[6];
                para[0] = new SqlParameter("@p_MaKhuyenMai", km.KhuyenMai.MaKhuyenMai == null ? "" : km.KhuyenMai.MaKhuyenMai);
                para[1] = new SqlParameter("@p_MaMatHang", km.MatHang.MaMatHang == null ? "" : km.MatHang.MaMatHang);
                para[2] = new SqlParameter("@p_GiaKhuyenMai", km.GiaKhuyenMai == null ? 0 : km.GiaKhuyenMai);
                para[3] = new SqlParameter("@p_SoLuong", km.SoLuong == null ? 0 : km.SoLuong);
                para[4] = new SqlParameter("@p_ThoiGianKT", km.KhuyenMai.ThoiGianKT == null ? "" : km.KhuyenMai.ThoiGianKT);
                para[5] = new SqlParameter("@p_TOP", 100);
                DataTable lstCTKhuyenMai = LoadDataTable("CT_KHUYENMAI_Search", para);

                return lstCTKhuyenMai;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
