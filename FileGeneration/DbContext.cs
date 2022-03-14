using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileGeneration
{
    public  class DbContext
    {
        SqlConnection connection = new SqlConnection("Server=R0maNga;Database=webdb;Trusted_Connection=True;");//"server=localhost;port=3306;username=root;password=root;databse=test");

        public  void openConnection(SqlConnection connetcion)
        {
            if(connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public SqlConnection GetMySqlConnection()
        {
            return connection;
        }

    }
}
