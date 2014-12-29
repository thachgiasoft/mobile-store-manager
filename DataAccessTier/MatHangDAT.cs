using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessTier;
using DataTransferObject;
using System.Data.SqlClient;

namespace DataAccessTier
{
    public class MatHangDAT: DataBases
    {
        public DataTable LayDanhSachTenMatHangTheoNhaCungCap(string MaNhaCungCap, int SoLuongToiThieu)
        {
            SqlParameter[] parameter = new SqlParameter[2];
            parameter[0] = new SqlParameter();
            parameter[0].ParameterName = "@p_MaNhaCungCap";
            parameter[0].Value = MaNhaCungCap;
            parameter[1] = new SqlParameter();
            parameter[1].ParameterName = "@p_SoLuongTon";
            parameter[1].Value = SoLuongToiThieu;
            try
            {
                return this.LoadDataTable("CT_NHACUNGCAP_Lst", parameter);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable LayDanhSachMatHang()
        {
            try
            {
                 return this.LoadDataTable("MATHANG_ListMH");               
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable LayDanhSachMatHangBan()
        {
            try
            {
                return this.LoadDataTable("MATHANG_Lst");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable TimKiemMatHang(MatHang matHang, int kichThuoc, string heDieuHanh, string mamauSac,
            int pin, int soSim, int ram, int boNho, string maCPU)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[12];
                para[0] = new SqlParameter("@p_MaMatHang", matHang.MaMatHang);
                para[1] = new SqlParameter("@p_TenMatHang", matHang.TenMatHang);
                para[2] = new SqlParameter("@p_MaLoaiMatHang", matHang.MaLoaiMatHang);
                para[3] = new SqlParameter("@p_MaNSX", matHang.MaNhaSanXuat);

                para[4] = new SqlParameter("@p_KichThuoc", kichThuoc);
                para[5] = new SqlParameter("@p_HeDieuHanh", heDieuHanh);
                para[6] = new SqlParameter("@p_MaMauSac", mamauSac);
                para[7] = new SqlParameter("@p_PIN", pin);
                para[8] = new SqlParameter("@p_SoSim", soSim);
                para[9] = new SqlParameter("@p_RAM", ram);
                para[10] = new SqlParameter("@p_BoNho", boNho);
                para[11] = new SqlParameter("@p_MaCPU", maCPU);


                DataTable lstNhaSX = LoadDataTable("MATHANG_Search", para);

                return lstNhaSX;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public bool XoaMatHang(String maMatHang)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[1];
                para[0] = new SqlParameter("@p_MaMatHang", maMatHang);

                int result = this.ExecuteNonQuery("MATHANG_Del", para);

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

        public bool ThemMatHang(MatHang matHang, CauHinhDienThoai cauhinh, string maNhaCC,
            string GhiChuNhaCC, DonGia donGia, HinhAnh hinh)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[20];
                para[0] = new SqlParameter("@p_TenMatHang", matHang.TenMatHang);
                para[1] = new SqlParameter("@p_MaLoaiMatHang", matHang.MaLoaiMatHang);
                para[2] = new SqlParameter("@p_MaNSX", matHang.MaNhaSanXuat);
                para[3] = new SqlParameter("@p_SoLuongTon", matHang.SoLuong);
                para[4] = new SqlParameter("@p_MaNCC", maNhaCC);
                para[5] = new SqlParameter("@p_GhiChuNhaCC", GhiChuNhaCC);
                para[6] = new SqlParameter("@p_GiaNhap", donGia.GiaNhap);
                para[7] = new SqlParameter("@p_GiaXuat", donGia.GiaXuat);
                para[8] = new SqlParameter("@p_ThoiGianBaoHanh", matHang.ThoiGianBaoHanh);
                para[9] = new SqlParameter("@p_Mota", matHang.MoTa);
                para[10] = new SqlParameter("@p_GhiChu", matHang.GhiChu);

                para[11] = new SqlParameter("@p_KichThuoc", cauhinh.KichThuocManHinh);
                para[12] = new SqlParameter("@p_HeDieuHanh", cauhinh.HeDieuHanh);
                para[13] = new SqlParameter("@p_Ram", cauhinh.Ram);
                para[14] = new SqlParameter("@p_MaMau", cauhinh.MaMauSac);
                para[15] = new SqlParameter("@p_Pin", cauhinh.DungLuongPin);
                para[16] = new SqlParameter("@p_MaCPU", cauhinh.MaCPU);
                para[17] = new SqlParameter("@p_BoNho", cauhinh.BoNho);
                para[18] = new SqlParameter("@p_SoSim", cauhinh.SoSim);

                para[19] = new SqlParameter("@p_NoiDung", hinh.NoiDungHinhAnh);

                int result = this.ExecuteNonQuery("MATHANG_Ins", para);
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

        public bool CapNhatMatHang(MatHang matHang, CauHinhDienThoai cauhinh, string maNhaCC,
           string GhiChuNhaCC, DonGia donGia, HinhAnh hinh)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[21];
                para[0] = new SqlParameter("@p_MaMatHang", matHang.MaMatHang);
                para[1] = new SqlParameter("@p_TenMatHang", matHang.TenMatHang);
                para[2] = new SqlParameter("@p_MaLoaiMatHang", matHang.MaLoaiMatHang);
                para[3] = new SqlParameter("@p_MaNSX", matHang.MaNhaSanXuat);
                para[4] = new SqlParameter("@p_SoLuongTon", matHang.SoLuong);
                para[5] = new SqlParameter("@p_MaNCC", maNhaCC);
                para[6] = new SqlParameter("@p_GhiChuNhaCC", GhiChuNhaCC);
                para[7] = new SqlParameter("@p_GiaNhap", donGia.GiaNhap);
                para[8] = new SqlParameter("@p_GiaXuat", donGia.GiaXuat);
                para[9] = new SqlParameter("@p_ThoiGianBaoHanh", matHang.ThoiGianBaoHanh);
                para[10] = new SqlParameter("@p_Mota", matHang.MoTa);
                para[11] = new SqlParameter("@p_GhiChu", matHang.GhiChu);

                para[12] = new SqlParameter("@p_KichThuoc", cauhinh.KichThuocManHinh);
                para[13] = new SqlParameter("@p_HeDieuHanh", cauhinh.HeDieuHanh);
                para[14] = new SqlParameter("@p_Ram", cauhinh.Ram);
                para[15] = new SqlParameter("@p_MaMau", cauhinh.MaMauSac);
                para[16] = new SqlParameter("@p_Pin", cauhinh.DungLuongPin);
                para[17] = new SqlParameter("@p_MaCPU", cauhinh.MaCPU);
                para[18] = new SqlParameter("@p_BoNho", cauhinh.BoNho);
                para[19] = new SqlParameter("@p_SoSim", cauhinh.SoSim);

                para[20] = new SqlParameter("@p_NoiDung", hinh.NoiDungHinhAnh);

                int result = this.ExecuteNonQuery("MATHANG_Upd", para);
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
