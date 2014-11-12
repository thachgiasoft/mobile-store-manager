using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QL_Ban_DienThoai.ConnectDB
{
    public class ConnectionDB
    {
        SqlConnection connection = new SqlConnection();
       
        public ConnectionDB()
        {
            
        }
              
#region tao ket noi csdl, xac dinh chuoi ket noi

        public SqlConnection CreateConnect()
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectString"].ConnectionString);// Sql 2008 express
            }
#endregion
    }
}
