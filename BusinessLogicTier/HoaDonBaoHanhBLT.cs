using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataTransferObject;
using DataAccessTier;
using System.Xml.Linq;

namespace BusinessLogicTier
{
    public class HoaDonBaoHanhBLT
    {
        private HoaDonBaoHanhDAT hdbhDAT;
        public HoaDonBaoHanhBLT()
        {
            hdbhDAT = new HoaDonBaoHanhDAT();
        }

        public DataTable LayDanhSachHoaDonBaoHanh()
        {
            try
            {
                return this.hdbhDAT.LayDanhSachHoaDonBaoHanh();
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
                return this.hdbhDAT.LayDanhSachTrangThai();
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
                return this.hdbhDAT.LayDanhSachKhachHang();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }

        public bool ThemHoaDonBaoHanh(HoaDonBaoHanh hdbh, XElement xml)
        {
            try
            {
                return this.hdbhDAT.ThemHoaDonBaoHanh(hdbh,xml);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhatHoaDonBaoHanh(HoaDonBaoHanh hdbh, XElement xml)
        {
            try
            {
                return this.hdbhDAT.CapNhatHoaDonBaoHanh(hdbh, xml);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return false;
        }

        public bool XoaHoaDonBaoHanh(String mahdbh)
        {
            try
            {
                return this.hdbhDAT.XoaHoaDonBaoHanh(mahdbh);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return false;
        }

        public DataTable TimKiemHoaDonBaoHanh(HoaDonBaoHanh hdbh)
        {
            try
            {
                return this.hdbhDAT.TimKiemHoaDonBaoHanh(hdbh);
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
                return this.hdbhDAT.TimKiemCTHoaDonBaoHanh(hdbh);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message = {1}", ex.Message);
            }
            return null;
        }
    }
}
