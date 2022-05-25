using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace KC_20_Gimalova_project_manager
{
    class DataBase
    {

        static string pathDB = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "DBManager.mdf");
        SqlConnection sqlConnection = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={pathDB};Integrated Security=True");

        //открывает связь с БД
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        //закрывает связь с БД
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        //возвращает строку подключения
        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
