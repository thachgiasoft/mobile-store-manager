using DataAccessTier;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLogicTier
{
    public class LePhiGiaoHangBLT
    {
        private LePhiGiaoHangDAT lePhiGiaoHangDAT;

        public LePhiGiaoHangBLT()
        {
            this.lePhiGiaoHangDAT = new LePhiGiaoHangDAT();
        }

        public DataTable LayDanhSachLePhiGiaoHang()
        {
            DataTable data = new DataTable();
            try
            {
                data = this.lePhiGiaoHangDAT.LayDanhSachLePhiGiaoHang();
                return data;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public bool ThemLePhiGiaoHang(LePhiGiaoHang lp)
        {
            try
            {
                return this.lePhiGiaoHangDAT.ThemLePhiGiaoHang(lp);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhatLePhiGiaoHang(LePhiGiaoHang lp)
        {

            try
            {
                return this.lePhiGiaoHangDAT.CapNhatLePhiGiaoHang(lp);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool XoaLePhiGiaoHang(String maLephi)
        {

            try
            {
                return this.lePhiGiaoHangDAT.XoaLePhiGiaoHang(maLephi);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public DataTable TimKiemLePhiGiaoHang(LePhiGiaoHang lp)
        {
            try
            {
                return this.lePhiGiaoHangDAT.TimKiemLePhiGiaoHang(lp);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }      
    }
}
