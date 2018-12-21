using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatacoKR
{
    class ConnectionJoin
    {
        private System.Data.SqlClient.SqlDataAdapter adapter;
        private SqlConnection conn;

        public ConnectionJoin()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SQL"].ConnectionString);
            adapter = new SqlDataAdapter();

        }

        public SqlConnection OpenConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed || conn.State == System.Data.ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }
        public SqlConnection CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return conn;
        }

        public DataTable ExcuteSelect()
        {
            SqlCommand command = new SqlCommand();
            adapter.SelectCommand = command;
            adapter.SelectCommand.Connection = OpenConnection();
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.CommandText = "DistinctRouteName";
            var a = adapter.SelectCommand.ExecuteReader();
            
            var data = new DataSet();

            try
            {
               
            }
            catch (Exception)
            {

                adapter.SelectCommand.Cancel();
                conn.Close();
            }
            
            return data.Tables["노선이름"];
            
           
        }
    }
}
