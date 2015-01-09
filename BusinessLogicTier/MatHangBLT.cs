using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using DataAccessTier;
using System.Data;

namespace BusinessLogicTier
{
    public class MatHangBLT
    {
        MatHangDAT _MatHangDAT;
        LoaiMatHangDAT _loaiMHDAT;
        NhaSanXuatDAT _nhaSXDAT;

        public MatHangBLT() {
            _MatHangDAT = new MatHangDAT();
            _loaiMHDAT = new LoaiMatHangDAT();
            _nhaSXDAT = new NhaSanXuatDAT();
        }

        public DataTable LayDanhSachTenMatHangTheoNhaCungCap(string  MaNhaCungCap, int SoLuongToiThieu)
        {
            return _MatHangDAT.LayDanhSachTenMatHangTheoNhaCungCap(MaNhaCungCap, SoLuongToiThieu);
        }

        public DataTable LayDanhSachMatHang()
        {
            DataTable data = new DataTable();
            try
            {
                data = this._MatHangDAT.LayDanhSachMatHang();
             
                foreach (DataRow row in data.Rows)
                {
                    _loaiMHDAT = new LoaiMatHangDAT();
                    row["Loại mặt hàng"] = _loaiMHDAT.LayTenLoaiMatHang(row["Loại mặt hàng"].ToString());
                    _nhaSXDAT = new NhaSanXuatDAT();
                    row["Nhà sản xuất"] = _nhaSXDAT.LayTenNhaSanXuat(row["Nhà sản xuất"].ToString());
                   
                }
                return data;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable LayDanhSachMatHangBan()
        {
            DataTable data = new DataTable();
            try
            {
                data = this._MatHangDAT.LayDanhSachMatHangBan();              
                return data;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }


     /*   public DataTable TimKiemMatHang(MatHang matHang, int kichThuoc, string heDieuHanh, string mauSac,
            int pin, int soSim, int ram, int boNho, string maCPU)
        {
            try
            {
                return this._MatHangDAT.TimKiemMatHang(matHang, kichThuoc, heDieuHanh,  mauSac,
                     pin, soSim, ram,boNho, maCPU);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }*/
        public DataTable TimKiemMatHang(MatHang matHang, decimal kichThuoc, string heDieuHanh, string mauSac,
           int pin, int soSim, int ram, int boNho, string maCPU)
        {
            DataTable data = new DataTable();
            try
            {
                data = this._MatHangDAT.TimKiemMatHang(matHang, kichThuoc, heDieuHanh, mauSac,
                     pin, soSim, ram, boNho, maCPU);

                foreach (DataRow row in data.Rows)
                {
                    _loaiMHDAT = new LoaiMatHangDAT();
                    string r2 = row[2].ToString();
                    row[2] = _loaiMHDAT.LayTenLoaiMatHang(r2);
                    _nhaSXDAT = new NhaSanXuatDAT();
                    row[3] = _nhaSXDAT.LayTenNhaSanXuat(row[3].ToString());

                }
                return data;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable TimKiemMatHangBan(MatHang matHang, int kichThuoc, string heDieuHanh, string mauSac,
         int pin, int soSim, int ram, int boNho, string maCPU)
        {
            DataTable data = new DataTable();
            try
            {
                data = this._MatHangDAT.TimKiemMatHangBan(matHang, kichThuoc, heDieuHanh, mauSac,
                     pin, soSim, ram, boNho, maCPU);

                //foreach (DataRow row in data.Rows)
                //{
                //    _loaiMHDAT = new LoaiMatHangDAT();
                //    row["Loại mặt hàng"] = _loaiMHDAT.LayTenLoaiMatHang(row["Loại mặt hàng"].ToString());
                //    _nhaSXDAT = new NhaSanXuatDAT();
                //    row["Nhà sản xuất"] = _nhaSXDAT.LayTenNhaSanXuat(row["Nhà sản xuất"].ToString());

                //}
                return data;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable TimKiemMatHangDonGian(MatHang matHang)
        {
            try
            {
                 return this._MatHangDAT.TimKiemMatHangDonGian(matHang);
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
                return this._MatHangDAT.XoaMatHang(maMatHang);
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
                return this._MatHangDAT.ThemMatHang(matHang, cauhinh,maNhaCC,
            GhiChuNhaCC, donGia, hinh);
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
                return this._MatHangDAT.CapNhatMatHang(matHang, cauhinh, maNhaCC,
            GhiChuNhaCC, donGia, hinh);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public string LayMaMatHangTuTenMatHangVaMaNhaCungCap(MatHang mh)
        {
            try
            {
                DataTable result = _MatHangDAT.LayMaMatHangTuTenMatHangVaMaNhaCungCap(mh);
                if (result != null && result.Rows.Count > 0)
                    return result.Rows[0].ItemArray[0].ToString();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable TimKiemMatHangBangTenMatHangDonGian(MatHang mh)
        {  
            try
            {
                DataTable result = _MatHangDAT.TimKiemMatHangBangTenMatHangDonGian(mh);
                if (result != null && result.Rows.Count > 0)
                    return result;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable LayThongTinDonGiaVaNhaSanXuat(MatHang mh)
        {  
            try
            {
                DataTable result = _MatHangDAT.LayThongTinDonGiaVaNhaSanXuat(mh);
                if (result != null && result.Rows.Count > 0)
                    return result;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
