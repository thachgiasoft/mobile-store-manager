using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace DataAccessTier
{
    public class HoaDonBaoHanhDAT:DataBases
    {
        public HoaDonBaoHanhDAT()
        {

        }

        public DataTable LayDanhSachHoaDonBaoHanh()
        {
            try
            {
                return this.LoadDataTable("HOADONBAOHANH_Lst");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
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
                Console.WriteLine("Message = {1}", ex.Message);
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
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public bool ThemHoaDonBaoHanh(HoaDonBaoHanh hd, XElement xml)
        {
            try
            {

                SqlParameter[] para = new SqlParameter[7];
                para[0] = new SqlParameter("@p_MaNhanVien", hd.HoaDon.NhanVien.MaNhanVien == null ? "" : hd.HoaDon.NhanVien.MaNhanVien);
                para[1] = new SqlParameter("@p_MaTrangThai", hd.HoaDon.TrangThai.MaTrangThai == null ? "" : hd.HoaDon.TrangThai.MaTrangThai);
                para[2] = new SqlParameter("@p_NgayLap", hd.HoaDon.NgayLap == null ? "1-1-2015" : hd.HoaDon.NgayLap);
                para[3] = new SqlParameter("@p_GhiChu", hd.HoaDon.GhiChu == null ? "" : hd.HoaDon.GhiChu);
                para[4] = new SqlParameter("@p_MaKhachHang", hd.KhachHang.MaKhachHang == null ? "" : hd.KhachHang.MaKhachHang);
                para[5] = new SqlParameter("@p_MaHoaDonBan", hd.HoaDonBan.HoaDon.MaHoaDon == null ? "" : hd.HoaDonBan.HoaDon.MaHoaDon);

                para[6] = new SqlParameter();
                para[6].ParameterName = "@p_XML_TEMP";
                para[6].DbType = DbType.Xml;
                para[6].Direction = ParameterDirection.Input;
                para[6].Value = xml.ToString();

                int result = this.ExecuteNonQuery("HOADONBAOHANH_Ins", para);
                if (result != 0)
                {
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhatHoaDonBaoHanh(HoaDonBaoHanh hd, XElement xml)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[8];
                para[0] = new SqlParameter("@p_MaHoaDon", hd.HoaDon.MaHoaDon == null ? "" : hd.HoaDon.MaHoaDon);
                para[1] = new SqlParameter("@p_MaNhanVien", hd.HoaDon.NhanVien.MaNhanVien == null ? "" : hd.HoaDon.NhanVien.MaNhanVien);
                para[2] = new SqlParameter("@p_MaTrangThai", hd.HoaDon.TrangThai.MaTrangThai == null ? "" : hd.HoaDon.TrangThai.MaTrangThai);
                para[3] = new SqlParameter("@p_NgayLap", hd.HoaDon.NgayLap == null ? "" : hd.HoaDon.NgayLap);
                para[4] = new SqlParameter("@p_GhiChu", hd.HoaDon.GhiChu == null ? "" : hd.HoaDon.GhiChu);
                para[5] = new SqlParameter("@p_MaKhachHang", hd.KhachHang.MaKhachHang == null ? "" : hd.KhachHang.MaKhachHang);
                para[6] = new SqlParameter("@p_MaHoaDonBan", hd.HoaDonBan.HoaDon.MaHoaDon == null ? "" : hd.HoaDonBan.HoaDon.MaHoaDon);

                para[7] = new SqlParameter();
                para[7].ParameterName = "@p_XML_TEMP";
                para[7].DbType = DbType.Xml;
                para[7].Direction = ParameterDirection.Input;
                para[7].Value = xml.ToString();
                int result = this.ExecuteNonQuery("HOADONBAOHANH_Upd", para);
                if (result != 0)
                {
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return false;
        }

        public bool XoaHoaDonBaoHanh(String maHoaDonBaoHanh)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@p_MaHoaDonBaoHanh", maHoaDonBaoHanh);

                int result = this.ExecuteNonQuery("HOADONBAOHANH_Del", para);
                if (result != 0)
                {
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return false;
        }

        public DataTable TimKiemHoaDonBaoHanh(HoaDonBaoHanh hd)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[6];
                para[0] = new SqlParameter("@p_NgayLap", hd.HoaDon.NgayLap == null ? "" : hd.HoaDon.NgayLap);
                para[1] = new SqlParameter("@p_MaHoaDonBaoHanh", hd.MaHoaDonBaoHanh == null ? "" : hd.MaHoaDonBaoHanh);
                para[2] = new SqlParameter("@p_TenKhachHang", hd.KhachHang.TenKhachHang == null ? "" : hd.KhachHang.TenKhachHang);
                para[3] = new SqlParameter("@p_MaKhachHang", hd.KhachHang.MaKhachHang == null ? "" : hd.KhachHang.MaKhachHang);
                para[4] = new SqlParameter("@p_MaHoaDonBan", hd.HoaDonBan.HoaDon.MaHoaDon == null ? "" : hd.HoaDonBan.HoaDon.MaHoaDon);
                para[5] = new SqlParameter("@p_TOP", 100);

                return this.LoadDataTable("HOADONBAOHANH_Search", para);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public DataTable TimKiemCTHoaDonBaoHanh(HoaDonBaoHanh hdbh)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[5];
                para[0] = new SqlParameter("@p_MaCTHoaDonBaoHanh", hdbh.CtHoaDonBH.MaCTHoaDonBaoHanh == null ? "" : hdbh.CtHoaDonBH.MaCTHoaDonBaoHanh);
                para[1] = new SqlParameter("@p_MaHoaDonBaoHanh", hdbh.HoaDon.MaHoaDon == null ? "" : hdbh.HoaDon.MaHoaDon);
                para[2] = new SqlParameter("@p_MaMatHang", hdbh.CtHoaDonBH.MatHang == null ? "" : hdbh.CtHoaDonBH.MatHang.MaMatHang);
                para[3] = new SqlParameter("@p_SoLuong", hdbh.CtHoaDonBH.SoLuong == null ? 0 : hdbh.CtHoaDonBH.SoLuong);
                para[4] = new SqlParameter("@p_TOP", 100);

                DataTable lstCTHoaDon = this.LoadDataTable("CT_HOADONBAOHANH_Search", para);
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
