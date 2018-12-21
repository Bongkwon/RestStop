using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmRestStop
{
    class DBConnection
    {
        private SqlConnection con;
        public DBConnection()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["FrmRestStop.Properties.Settings.RestStopConnectionString"].ConnectionString);
        }
        private SqlConnection OpenConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed || con.State == System.Data.ConnectionState.Broken)
            {
                con.Open();
            }
            return con;
        }
        internal bool ExcuteInsert(string sp, SqlParameter[] sqlParameters)
        {
            bool result = false;

            SqlCommand command = new SqlCommand();
            command.Connection = OpenConnection();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sp;
            //sqlParameters
            if (sqlParameters != null)
            {
                command.Parameters.AddRange(sqlParameters);
            }

            if (command.ExecuteNonQuery() == 1)
            {
                result = true;
            }
            return result;
        }
    }
}
