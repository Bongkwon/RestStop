using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatacoKR
{
    public partial class SeolhwaPar : Form
    {
        private int numOfRow = 20;  // 데이터 개수
        private static int pageNo = 1;
        private int count = 0;  //전체 데이터 개수
        private int pageTotal=0;
        
        internal static List<Highway> highways = new List<Highway>();
        string conn = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;

        

        public SeolhwaPar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void IDbConnection(List<Highway> highway)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();
                foreach (Highway item in highway)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertRoute";

                    cmd.Parameters.AddWithValue("@unitName", item.UnitName);
                    cmd.Parameters.AddWithValue("@unitCode", item.UnitCode);
                    cmd.Parameters.AddWithValue("@routeNo", item.RouteNo);
                    cmd.Parameters.AddWithValue("@routeName", item.RouteName);
                    cmd.Parameters.AddWithValue("@xValue", item.XValue);
                    cmd.Parameters.AddWithValue("@yValue", item.YValue);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {

                        break;

                    }
                    
                }
                con.Close();
                
            }
        }

        private string RequestResponse(string serVal)
        {
            string json = "";
            var req = (HttpWebRequest)WebRequest.Create(serVal);
            var res = (HttpWebResponse)req.GetResponse();

            
            var stream = res.GetResponseStream();
            var sr = new StreamReader(stream, Encoding.UTF8);

            
            textBox1.Text = sr.ReadToEnd();
            json = textBox1.Text;

            return json;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            highways.Clear();

            string key = "xHuTDf0%2FQp0HDzRAEV4eJFw%2F8hAJu7mZ8oFyqowX7jn6I56Au1cimmwHtweVDfYznMmcv6cXg%2BnXwmnOtHQ%2FOw%3D%3D";    // 인증키
            //"http://data.ex.co.kr/exopenapi/locationinfo/locationinfoRest?serviceKey="+key+"&type=json&numOfRows="+ numOfRow + "&pageNo="+ pageNo

            var serVal = "http://data.ex.co.kr/exopenapi/locationinfo/locationinfoRest?serviceKey=" + key + "&type=json&numOfRows=" + numOfRow + "&pageNo=" + pageNo;



            RequestResponse(serVal);
            var jObj = JObject.Parse(RequestResponse(serVal));


            if (Int32.Parse(jObj["count"].ToString()) == 0)
            {
                button1_Click(null, null);
            }



            count = Int32.Parse(jObj["count"].ToString());
            //전체 데이터 개수


            for (int i = 0; i < Int32.Parse(jObj["pageSize"].ToString()); i++)
            {
                var itemsArr = JArray.Parse(jObj["list"].ToString());

                foreach (JObject item in itemsArr)
                {
                    Highway highway = new Highway()
                    {
                        UnitName = item["unitName"].ToString(),
                        UnitCode = item["unitCode"].ToString(),
                        RouteNo = item["routeNo"].ToString(),
                        RouteName = item["routeName"].ToString(),
                        XValue = item["xValue"].ToString(),
                        YValue = item["yValue"].ToString()
                    };
                    highways.Add(highway);


                }

                pageNo++;

                IDbConnection(highways);
                highways.Clear();

                serVal = "http://data.ex.co.kr/exopenapi/locationinfo/locationinfoRest?serviceKey=" + key + "&type=json&numOfRows=" + numOfRow + "&pageNo=" + pageNo;

                jObj = JObject.Parse(RequestResponse(serVal));

                if (Int32.Parse(jObj["count"].ToString()) == 0)
                {
                    button1_Click(null, null);
                }


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from dbo.RouteTable";
                var re = cmd.ExecuteReader();
                while (re.Read())
                {
                    Highway highway = new Highway()
                    {
                        UnitCode = re["unitCode"].ToString(),
                        UnitName = re["unitName"].ToString(),
                        RouteNo = re["routeNo"].ToString(),
                        RouteName = re["routeName"].ToString(),
                        XValue = re["xValue"].ToString(),
                        YValue = re["yValue"].ToString()
                    };
                    highways.Add(highway);
                }
                this.dataGridView1.DataSource = highways;

                con.Close();


            }
        }
    }
}
