using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessTier;

namespace BusinessLogicTier
{
   public class MatHangBLT
    {
       private MatHangDAT matHangBLT;
       public MatHangBLT() 
       {
           matHangBLT = new MatHangDAT();
       }

       public DataTable LayDanhSachMatHang()
       {
           DataTable data = new DataTable();
           try
           {
               data = this.matHangBLT.LayDanhSachMatHang();             
               return data;
           }
           catch (System.Exception ex)
           {
               Console.WriteLine("Message= {1}", ex.Message);
           }
           return null;
       }
    }
}
