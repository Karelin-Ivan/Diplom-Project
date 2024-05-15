using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Input;
using System.Data;

namespace MSSQL
{
    class DataBaseCommands
    {
        
        public static string[] GetCartriges()
        {
            DataBase dataBase = new DataBase();
            dataBase.openConnection();
            string querystring = $"SELECT DISTINCT model FROM Сartridges";
            SqlCommand command = new SqlCommand(querystring, dataBase.getSqlConnection());
            string querystringCount = $"SELECT COUNT (DISTINCT model) FROM Сartridges";
            SqlCommand commandCount = new SqlCommand(querystringCount, dataBase.getSqlConnection());
            
            int count = (int)commandCount.ExecuteScalar();
            string[] mass = new string[count];

            using (SqlDataReader reader = command.ExecuteReader())
            {
                int i = 0;
                while (reader.Read())
                {
                    mass[i] = reader.GetString(0);
                    i++;
                }
            }
            dataBase.closeConnection();
            return mass;
        }
    }
}
