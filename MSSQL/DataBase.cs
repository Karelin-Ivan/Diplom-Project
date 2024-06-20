using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MSSQL
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=IVAN\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
        //SqlConnection sqlConnection = new SqlConnection(@"Data Source=192.168.0.104,49170;Initial Catalog=Project;User ID=MSSQLPROFILE;Password=sa");


        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection getSqlConnection() 
        { 
            return sqlConnection; 
        }
    }
}
