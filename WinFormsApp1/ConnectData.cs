using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    class ConnectData
    {
        public SqlConnection conn;
        public SqlCommand cmd;
        public void connect()
        {
            string connectString = @"Data Source=localhost;Initial Catalog=Storage1;Integrated Security=True";
            conn = new SqlConnection(connectString);
            conn.Open();
  
  
        }

        public void connectImport()
        {
            string connectString = @"Data Source =localhost; Initial Catalog = Storage1; User ID = Import ; Password = 123456789; TrustServerCertificate=True";
            conn = new SqlConnection(connectString);
            conn.Open();
        }

        public void connectSale()
        {
            string connectString = @"Data Source =localhost; Initial Catalog = Storage1; User ID = Sale ; Password = 123456789; TrustServerCertificate=True";
            conn = new SqlConnection(connectString);
            conn.Open();
        }


        public void disconnect()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }



    }
}

