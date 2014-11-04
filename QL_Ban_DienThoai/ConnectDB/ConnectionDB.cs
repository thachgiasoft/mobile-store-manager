using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_Ban_DienThoai.ConnectDB
{
    public struct ConnectionDB
    {

        private string _DataSource;
        private string _DataPath;
        public ConnectionDB(string DataPath = "", string DataSource = "")
        {
            _DataPath = DataPath;
            _DataSource = DataSource;
            //SqlServer.DatabaseName = @"F:\PROJECT C#\QLNS\QLNS\BIN\DEBUG\NHASACH.MDF";
            //SqlServer s = new SqlServer();
            //s.FindAvailableServer();
            //s.FindConnectionString();
        }
              
#region tao ket noi csdl, xac dinh chuoi ket noi

        public SqlConnection CreateConnect()
            {
                //SqlServer.DatabaseName = @"F:\PROJECT C#\QLNS\QLNS\BIN\DEBUG\NHASACH.MDF";
                //SqlServer s = new SqlServer();
                //s.FindAvailableServer();
                //s.FindConnectionString();

                 //_DataPath   = Application.StartupPath + "\\NhaSach.mdf";
                 //_DataSource = SystemInformation.ComputerName;
            //AttachDbFilename = " + _DataPath + 
                return new SqlConnection(@"Data Source = .\SQLEXPRESS;Initial Catalog=F:\PROJECT C#\QLNS\QLNS\BIN\DEBUG\NHASACH.MDF;Integrated Security=True");// Sql 2008 express
            }
#endregion
    }
}
