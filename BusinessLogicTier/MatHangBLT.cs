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
                    row["Loại mặt hàng"] = _loaiMHDAT.GetTenLoaiMatHang(row["Loại mặt hàng"].ToString());
                    _nhaSXDAT = new NhaSanXuatDAT();
                    row["Nhà sản xuất"] = _nhaSXDAT.GetTenNhaSanXuat(row["Nhà sản xuất"].ToString());
                   
                }
                return data;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable TimKiemMatHang(MatHang matHang, int kichThuoc, string heDieuHanh, string mauSac,
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
            string GhiChuNhaCC, DonGia donGia)
        {
            try
            {
                return this._MatHangDAT.ThemMatHang(matHang, cauhinh,maNhaCC,
            GhiChuNhaCC, donGia);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhatMatHang(MatHang matHang, CauHinhDienThoai cauhinh, string maNhaCC,
           string GhiChuNhaCC, DonGia donGia)
        {
            try
            {
                return this._MatHangDAT.CapNhatMatHang(matHang, cauhinh, maNhaCC,
            GhiChuNhaCC, donGia);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }
    }
}
