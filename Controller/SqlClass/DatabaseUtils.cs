using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySqlConnector;

namespace MaterialScale2MES
{
    class DatabaseUtils
    {
        //Data connection to get data 
        #region BaseDataCon 
        public static MySqlConnection GetMes_Base_DataDBC()
        {
            string host = "172.16.0.22";
            string user = "root";
            string password = "cloud-123456";
            string database = "mes_base_data";

            return DatabaseSQLServerUtils.GetMesDBConnection(host, user, password, database);
        }

        public static MySqlConnection GetMes_Planning_ExcutionDBC()
        {
            string host = "172.16.0.22";
            string user = "root";
            string password = "cloud-123456";
            string database = "mes_planning_excution";

            return DatabaseSQLServerUtils.GetMesDBConnection(host, user, password, database);
        }

        public static MySqlConnection GetMes_Quality_ControlDBC()
        {
            string host = "172.16.0.22";
            string user = "guest";
            string password = "guest@123";
            string database = "mes_quality_control";

            return DatabaseSQLServerUtils.GetMesDBConnection(host, user, password, database);
        }
        #endregion
    }
}
