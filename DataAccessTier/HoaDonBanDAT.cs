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
    public class HoaDonBanDAT : DataBases
    {
        public HoaDonBanDAT()
        {
           
        }

        public DataTable LayDanhSachHoaDon()
        {
            try
            {
                return this.LoadDataTable("HOADONBAN_Lst");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }       
            return null;
        }

        public DataTable LayDanhSachKhachHang()
        {
            try
            {
                return this.LoadDataTable("KHACHHANG_Lst");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable LayDanhSachTrangThai()
        {
            try
            {
                return this.LoadDataTable("TRANGTHAI_Lst");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public bool ThemHoaDon(HoaDonBan hd, XElement xml)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[12];
                para[0] = new SqlParameter("@p_MaNhanVien", hd.HoaDon.NhanVien.MaNhanVien == null ? "" : hd.HoaDon.NhanVien.MaNhanVien);
                para[1] = new SqlParameter("@p_MaTrangThai", hd.HoaDon.TrangThai.MaTrangThai == null ? "" : hd.HoaDon.TrangThai.MaTrangThai);
                para[2] = new SqlParameter("@p_TongTien", hd.HoaDon.TongTien == null ? Decimal.Zero : hd.HoaDon.TongTien);
                para[3] = new SqlParameter("@p_TienDaTT", hd.HoaDon.TienDaTT == null ? Decimal.Zero : hd.HoaDon.TienDaTT);
                para[4] = new SqlParameter("@p_NgayLap", hd.HoaDon.NgayLap == null ? "" : hd.HoaDon.NgayLap);
                para[5] = new SqlParameter("@p_GhiChu", hd.HoaDon.GhiChu == null ? "" : hd.HoaDon.GhiChu);
                para[6] = new SqlParameter("@p_MaKhachHang", hd.KhachHang.MaKhachHang == null ? "" : hd.KhachHang.MaKhachHang);
                para[7] = new SqlParameter("@p_DiaChiGiaoHang", hd.DiaChiGH == null ? "" : hd.DiaChiGH);
                para[8] = new SqlParameter("@p_MaKhuVuc", hd.LePhiGiaoHang.MaKhuVuc == null ? null : hd.LePhiGiaoHang.MaKhuVuc);
                para[9] = new SqlParameter("@p_NgayGiaoHang", hd.NgayGiaoHang == null ? null : hd.NgayGiaoHang);
                para[10] = new SqlParameter("@p_NgayTT", hd.NgayTT == null ? "" : hd.NgayTT);

                para[11] = new SqlParameter();
                para[11].ParameterName = "@p_XML_TEMP";
                para[11].DbType = DbType.Xml;
                para[11].Direction = ParameterDirection.Input;
                para[11].Value = xml.ToString();
                int result = this.ExecuteNonQuery("HOADONBAN_Ins", para);

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

        public bool CapNhatHoaDon(HoaDonBan hd, XElement xml)
        {
              try
              {
                  SqlParameter[] para = new SqlParameter[13];
                  para[0] = new SqlParameter("@p_MaHoaDon", hd.HoaDon.MaHoaDon == null ? "" : hd.HoaDon.MaHoaDon);
                  para[1] = new SqlParameter("@p_MaNhanVien", hd.HoaDon.NhanVien.MaNhanVien == null ? "" : hd.HoaDon.NhanVien.MaNhanVien);
                  para[2] = new SqlParameter("@p_MaTrangThai", hd.HoaDon.TrangThai.MaTrangThai == null ? "" : hd.HoaDon.TrangThai.MaTrangThai);
                  para[3] = new SqlParameter("@p_TongTien", hd.HoaDon.TongTien == null ? Decimal.Zero : hd.HoaDon.TongTien);
                  para[4] = new SqlParameter("@p_TienDaTT", hd.HoaDon.TienDaTT == null ? Decimal.Zero : hd.HoaDon.TienDaTT);
                  para[5] = new SqlParameter("@p_NgayLap", hd.HoaDon.NgayLap == null ? "" : hd.HoaDon.NgayLap);
                  para[6] = new SqlParameter("@p_GhiChu", hd.HoaDon.GhiChu == null ? "" : hd.HoaDon.GhiChu);
                  para[7] = new SqlParameter("@p_MaKhachHang", hd.KhachHang.MaKhachHang == null ? "" : hd.KhachHang.MaKhachHang);
                  para[8] = new SqlParameter("@p_DiaChiGiaoHang", hd.DiaChiGH == null ? "" : hd.DiaChiGH);
                  para[9] = new SqlParameter("@p_MaKhuVuc", hd.LePhiGiaoHang.MaKhuVuc == null ? "" : hd.LePhiGiaoHang.MaKhuVuc);
                  para[10] = new SqlParameter("@p_NgayGiaoHang", hd.NgayGiaoHang == null ? "" : hd.NgayGiaoHang);
                  para[11] = new SqlParameter("@p_NgayTT", hd.NgayTT == null ? "" : hd.NgayTT);

                  para[12] = new SqlParameter();
                  para[12].ParameterName = "@p_XML_TEMP";
                  para[12].DbType = DbType.Xml;
                  para[12].Direction = ParameterDirection.Input;
                  para[12].Value = xml.ToString();
                  int result = this.ExecuteNonQuery("HOADONBAN_Upd", para);
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

        public bool XoaHoaDon(String maHoaDon)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@MaHoaDonBan", maHoaDon);
                int result = this.ExecuteNonQuery("HOADONBAN_Del", para);

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

        public DataTable TimKiemHoaDon(HoaDonBan hd)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[10];
                para[0] = new SqlParameter("@p_TenNhanVien", hd.HoaDon.NhanVien.TenNhanVien == null ? "" : hd.HoaDon.NhanVien.TenNhanVien);
                para[1] = new SqlParameter("@p_MaTrangThai", hd.HoaDon.TrangThai.MaTrangThai == null ? "" : hd.HoaDon.TrangThai.MaTrangThai);
                para[2] = new SqlParameter("@p_NgayLap", hd.HoaDon.NgayLap == null ? "" : hd.HoaDon.NgayLap);
                para[3] = new SqlParameter("@p_MaHoaDonBan", hd.HoaDon.MaHoaDon == null ? "" : hd.HoaDon.MaHoaDon);
                para[4] = new SqlParameter("@p_TenKhachHang", hd.KhachHang.TenKhachHang == null ? "" : hd.KhachHang.TenKhachHang);
                para[5] = new SqlParameter("@p_DiaChiGiaoHang", hd.DiaChiGH == null ? "" : hd.DiaChiGH);
                para[6] = new SqlParameter("@p_MaKhuVuc", hd.LePhiGiaoHang.MaKhuVuc == null ? "" : hd.LePhiGiaoHang.MaKhuVuc);
                para[7] = new SqlParameter("@p_NgayGiaoHang", hd.NgayGiaoHang == null ? "" : hd.NgayGiaoHang);
                para[8] = new SqlParameter("@p_NgayTT", hd.NgayTT == null ? "" : hd.NgayTT);
                para[9] = new SqlParameter("@p_TOP", 100);

                DataTable lstHoaDon = this.LoadDataTable("HOADONBAN_Search", para);
                return lstHoaDon;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }    
            return null;
        }

        public DataTable TimKiemCTHoaDon(HoaDonBan hd)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[5];
                para[0] = new SqlParameter("@p_MaCTHoaDon", hd.CtHoaDon.MaCTHoaDonBan == null ? "" : hd.CtHoaDon.MaCTHoaDonBan);
                para[1] = new SqlParameter("@p_MaHoaDonBan", hd.HoaDon.MaHoaDon == null ? "" : hd.HoaDon.MaHoaDon);
                para[2] = new SqlParameter("@p_MaMatHang", hd.CtHoaDon.MatHang == null ? "" : hd.CtHoaDon.MatHang.MaMatHang);
                para[3] = new SqlParameter("@p_SoLuong", hd.CtHoaDon.SoLuong == null ? 0 : hd.CtHoaDon.SoLuong);
                para[4] = new SqlParameter("@p_TOP", 100);

                DataTable lstCTHoaDon = this.LoadDataTable("CT_HOADONBAN_Search", para);
                return lstCTHoaDon;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
