using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rest
{
    public partial class Form1 : Form
    {
        internal static List<RouteFac> lstRoute = new List<RouteFac>();
        internal static List<RestStopFac> lstRestStop = new List<RestStopFac>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new FrmRestStopFacilities().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SelectAllInRestStop";
                con.Open();
                var datas = cmd.ExecuteReader();
                while (datas.Read())
                {
                    lstRestStop.Add(new RestStopFac(datas["batchMenu"].ToString(), datas["brand"].ToString(), datas["convenience"].ToString(), datas["direction"].ToString(), datas["serviceAreaCode"].ToString(), datas["serviceAreaName"].ToString(), datas["telNo"].ToString(), datas["truckSaYn"].ToString()));
                }
                con.Close();
                
                con.Open();
                cmd.CommandText = "SelectAllInRoute";
                datas = cmd.ExecuteReader();
                while (datas.Read())
                {
                    lstRoute.Add(new RouteFac(datas["batchMenu"].ToString(), datas["brand"].ToString(), datas["convenience"].ToString(), datas["direction"].ToString(), datas["serviceAreaCode"].ToString(), datas["serviceAreaName"].ToString(), datas["telNo"].ToString(), datas["truckSaYn"].ToString(), datas["routeName"].ToString()));
                }
                con.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FrmRouteFacilities().Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new FrmGasStation().Show();
        }
    }
}
