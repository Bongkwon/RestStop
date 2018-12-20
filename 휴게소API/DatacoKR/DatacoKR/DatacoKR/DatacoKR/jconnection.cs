using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatacoKR
{
    class jconnection
    {
        private System.Data.SqlClient.SqlDataAdapter adapter;
        private SqlConnection conn;

        public jconnection()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQL"].ConnectionString);


        }
        private SqlConnection OpenConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed || conn.State == System.Data.ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }
        private DataTable ExcuteSelect()
        {
            SqlCommand command = new SqlCommand();
            adapter.SelectCommand = command;
            adapter.SelectCommand.Connection = OpenConnection();
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.CommandText = "DistinctRouteName";
            

        }
    }
}
