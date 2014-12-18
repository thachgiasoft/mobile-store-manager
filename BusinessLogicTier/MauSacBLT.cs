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
    public class MauSacBLT
    {
        private MauSacDAT mauSacDAT;

        public MauSacBLT()
        {
            this.mauSacDAT = new MauSacDAT();
        }

        public DataTable LoadComBoBox()
        {
            try
            {
                return this.mauSacDAT.LoadComboBox();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public DataTable LayDanhSachMauSac()
        {
            DataTable data = new DataTable();
            try
            {
                data = this.mauSacDAT.LayDanhSachMauSac();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    // data.Rows[i].
                }
                return data;
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }

        public bool ThemMauSac(MauSac mauSac)
        {
            try
            {
                return this.mauSacDAT.ThemMauSac(mauSac);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool CapNhatMauSac(MauSac mauSac)
        {

            try
            {
                return this.mauSacDAT.CapNhatMauSac(mauSac);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public bool XoaMauSac(String maMauSac)
        {

            try
            {
                return this.mauSacDAT.XoaMauSac(maMauSac);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

        public DataTable TimKiemMauSac(MauSac mauSac)
        {
            try
            {
                return this.mauSacDAT.TimKiemMauSac(mauSac);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
