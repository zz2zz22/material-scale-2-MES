using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using MySqlConnector;

namespace MaterialScale2MES
{
    class DatabaseSQLServerUtils
    {
        public static MySqlConnection GetMesDBConnection(string host, string user, string password, string database)
        {
            string connectionString = String.Format("host={0};user={1};password={2}; database={3};", host, user, password, database);
            MySqlConnection con = new MySqlConnection(connectionString);
            return con;
        }
    }
}
