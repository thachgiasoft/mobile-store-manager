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
    public class NhaSanXuatBLT
    {
          private NhaSanXuatDAT nhaSXDAT;

          public NhaSanXuatBLT()
        {
            this.nhaSXDAT = new NhaSanXuatDAT();
        }

          public string LayMaNhaSanXuat(string tenNhaSX)
          {
              try
              {
                  return this.nhaSXDAT.LayMaNhaSanXuat(tenNhaSX);
              }
              catch (System.Exception ex)
              {
                  Console.WriteLine("Message= {1}", ex.Message);
              }

              return null;
          }

          public DataTable LoadComBoBox()
          {
              try
              {
                  return this.nhaSXDAT.LoadComboBox();
              }
              catch (System.Exception ex)
              {
                  Console.WriteLine("Message= {1}", ex.Message);
              }
              return null;
          }

          public DataTable LayDanhSachNhaSanXuat()
        {
            DataTable data = new DataTable();
            try
            {
                data = this.nhaSXDAT.LayDanhSachNhaSanXuat();
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

          public bool ThemNhaSanXuat(NhaSanXuat nhaSX)
        {
            try
            {
                return this.nhaSXDAT.ThemNhaSanXuat(nhaSX);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

          public bool CapNhatNhaSanXuat(NhaSanXuat nhaSX)
        {

            try
            {
                return this.nhaSXDAT.CapNhatNhaSanXuat(nhaSX);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

          public bool XoaNhaSanXuat(String maNhaSX)
        {

            try
            {
                return this.nhaSXDAT.XoaNhaSanXuat(maNhaSX);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return false;
        }

          public DataTable TimKiemNhaSanXuat(NhaSanXuat nhaSX)
        {
            try
            {
                return this.nhaSXDAT.TimKiemNhaSanXuat(nhaSX);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Message= {1}", ex.Message);
            }
            return null;
        }
    }
}
