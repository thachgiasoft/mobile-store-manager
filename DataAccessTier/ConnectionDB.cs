﻿using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DataAccessTier
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
               String _DataSource = SystemInformation.ComputerName;
              // return new SqlConnection(ConfigurationManager.ConnectionStrings["connectdb"].ConnectionString);
			   return new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QLBANHANG_LINHKIEN_DIENTHOAI;Integrated Security=True");  
            }
#endregion
    }
}
