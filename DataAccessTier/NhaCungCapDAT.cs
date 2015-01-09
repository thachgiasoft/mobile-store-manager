using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessTier;
using DataTransferObject;
using System.Data.SqlClient;


namespace DataAccessTier
{
    public class NhaCungCapDAT : DataBases
    {
        public DataTable layDanhSachNhaCungCap()
        {
            try
            {
                return this.LoadDataTable("NHACUNGCAP_ListNCC");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }


        public DataTable LoadComboBox()
        {
            try
            {
                return this.LoadDataTable("NHACUNGCAP_Lst");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public bool ThemNhaCungCap(NhaCungCap nhaCC)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[4];
                para[0] = new SqlParameter("@p_TenNhaCungCap", nhaCC.TenNhaCungCap);
                para[1] = new SqlParameter("@p_DiaChi", nhaCC.DiaChi);
                para[2] = new SqlParameter("@p_SoDienThoai", nhaCC.SoDienThoai);
                para[3] = new SqlParameter("@p_Web", nhaCC.Web);
               

                int result = this.ExecuteNonQuery("NHACUNGCAP_Ins", para);
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

        public bool CapNhatNhaCungCap(NhaCungCap nhaCC)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[5];
                para[0] = new SqlParameter("@p_MaNhaCungCap", nhaCC.MaNhaCungCap);
                para[1] = new SqlParameter("@p_TenNhaCungCap", nhaCC.TenNhaCungCap);
                para[2] = new SqlParameter("@p_DiaChi", nhaCC.DiaChi);
                para[3] = new SqlParameter("@p_SoDienThoai", nhaCC.SoDienThoai);
                para[4] = new SqlParameter("@p_Web", nhaCC.Web);
              

                int result = this.ExecuteNonQuery("NHACUNGCAP_Upd", para);
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

        public bool XoaNhaCungCap(String maNhaCC)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@MaNhaCungCap", maNhaCC);

                int result = this.ExecuteNonQuery("NHACUNGCAP_Del", para);

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

        public DataTable TimKiemNhaCungCap(NhaCungCap nhaCC)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[5];
                para[0] = new SqlParameter("@p_MaNhaCungCap", nhaCC.MaNhaCungCap);
                para[1] = new SqlParameter("@p_TenNhaCungCap", nhaCC.TenNhaCungCap);
                para[2] = new SqlParameter("@p_DiaChi", nhaCC.DiaChi);
                para[3] = new SqlParameter("@p_SoDienThoai", nhaCC.SoDienThoai);
                para[4] = new SqlParameter("@p_Web", nhaCC.Web);


                DataTable lstNhaCC = LoadDataTable("NHACUNGCAP_Search", para);

                return lstNhaCC;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable LayMaCCBangMaSanPham(string maSanPham)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@p_MaSanPham", maSanPham);


                DataTable nhaCC = LoadDataTable("NHACUNGCAP_GetByMaSanPham", para);
                return nhaCC;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
        public DataTable LayMaNhaCCBangTenNhaCungCap(string tenNhaCungCap)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@p_TenNhaCC", tenNhaCungCap);
                DataTable nhaCC = LoadDataTable("LayMaNCCTuTenNhaCC", para);
                return nhaCC;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public bool XoaChiTietNhaCungCap(string mamathang)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@p_MaMatHang", mamathang);

                int result = this.ExecuteNonQuery("xoachitietnhacungcapdongia_L", para);

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
        public bool ThemChiTietNhaCungCap(ChiTietNhaCungCap ncc)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[4];
                para[0] = new SqlParameter("@p_MaMatHang", ncc.MaMatHang);
                para[1] = new SqlParameter("@p_MaNhaCungCap", ncc.MaNhaCungCap);
                para[2] = new SqlParameter("@p_MaDonGia", ncc.MaDonGia);
                para[3] = new SqlParameter("@p_GhiChu", ncc.GhiChu);

                int result = this.ExecuteNonQuery("CT_NHACUNGCAP_Ins_new_L", para);

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
    }
}
