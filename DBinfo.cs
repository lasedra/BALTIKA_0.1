using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltikaApp
{
    public class DBinfo
    {
        public SqlConnection sqlConnection = new SqlConnection
            (@"Server=.\SQLEXPRESS;Initial Catalog=BALTIKA;Integrated Security=True;TrustServerCertificate=True");

        public void openConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
                sqlConnection.Close();
        }

        public SqlConnection getConnection()
        { 
            return sqlConnection; 
        }
    }
}
