using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DataTransferObject;
using DataAccessTier;

namespace BusinessLogicTier
{
    public class NhanVienBLT 
    {
        private NhanVienDAT nhanVienDAT;

        public NhanVienBLT()
        {
            this.nhanVienDAT = new NhanVienDAT();
        }

        public DataTable LayDanhSachNhanVien()
        {
            try
            {
                return this.nhanVienDAT.LayDanhSachNhanVien();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public bool ThemNhanVien(NhanVien nhanVien)
        {
            try
            {
                return this.nhanVienDAT.ThemNhanVien(nhanVien);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhatNhanVien(NhanVien nhanVien)
        {

            try
            {
                return this.nhanVienDAT.CapNhatNhanVien(nhanVien);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool XoaNhanVien(String maNhanVien)
        {

            try
            {
                return this.nhanVienDAT.XoaNhanVien(maNhanVien);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public DataTable TimKiemNhanVien(NhanVien nhanVien)
        {
            try
            {
                return this.nhanVienDAT.TimKiemNhanVien(nhanVien);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
        
    }
}
