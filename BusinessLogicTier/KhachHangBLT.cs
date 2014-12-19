using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DataAccessTier;
using DataTransferObject;
using System.Data.SqlClient;

namespace BusinessLogicTier
{
    public class KhachHangBLT
    {
        private KhachHangDAT khDAT;

        public KhachHangBLT()
        {
            this.khDAT = new KhachHangDAT();
        }
        public DataTable LayDanhSachKhachHang()
        {
            
            try
            {
                return this.khDAT.LayDanhSachKhachHang();
                
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public bool ThemKhachHang(KhachHang kh)
        {
            try
            {
                return this.khDAT.ThemKhachHang(kh);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhatKhachHang(KhachHang kh)
        {
            try
            {
                return this.khDAT.CapNhatKhachHang(kh);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return false;
        }

        public bool XoaKhachHang(String maKhachHang)
        {
            try
            {
                return this.khDAT.XoaKhachHang(maKhachHang);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return false;

        }

        public DataTable TimKiemKhachHang(KhachHang kh)
        {
            try
            {
                return this.khDAT.TimKiemKhachHang(kh);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }
    }
}
