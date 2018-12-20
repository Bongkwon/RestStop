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
using System.Windows.Media;
using System.Xml;

namespace DatacoKR
{
    public partial class SelectJoin : Form
    {
        
        public SelectJoin()
        {
            InitializeComponent();
        }
        Map map;
        ConnectionJoin conn = new ConnectionJoin();
        List<string> highways = new List<string>();

        private static List<Map> maps = new List<Map>();

        public static List<Map> Maps { get => maps; set => maps = value; }

        private void SelectJoin_Load(object sender, EventArgs e)
        {
            //ConnectionJoin conn = new ConnectionJoin();

            //comboBox1.Items.Add(conn.ExcuteSelect());
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = maps[0].Address_name;
            label8.Text = maps[0].Phone;
            label9.Text = maps[0].Place_name;
            linkLabel1.Text = maps[0].Place_url;
            
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = conn.OpenConnection();
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "SelectJoin";
            //var r = cmd.ExecuteReader();

            ////MessageBox.Show(comboBox1.SelectedItem.ToString());
            //DataTable table = new DataTable();
            //table.Columns.Add("휴게소 이름");
            //table.Columns.Add("대표메뉴");
            //table.Columns.Add("전화번호");
            

            //while (r.Read())
            //{
            //    DataRow row = table.NewRow();

            //    row["휴게소 이름"] = r["unitName"].ToString();
            //    row["대표메뉴"] = r["batchMenu"].ToString();
            //    row["전화번호"] = r["telNo"].ToString();
            //    table.Rows.Add(row);

            //}
            

            //dataGridView1.DataSource = table;

            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.OpenConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SelectRest";
            SqlParameter[] sqlParameter = new SqlParameter[1];
            sqlParameter[0] = new SqlParameter("@routeName", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddRange(sqlParameter);
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                highways.Add(r["unitName"].ToString());
            }

            foreach (string item in highways)
            {
                comboBox2.Items.Add(item);
            }

            conn.CloseConnection();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CCTVDate data = new CCTVDate();
            data.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            maps.Clear();
            string location = comboBox2.SelectedItem.ToString();
            
            System.Web.HttpUtility.UrlEncode(location);
            //"https://dapi.kakao.com/v2/local/search/keyword.json?query=" + location;

            string addr = "https://dapi.kakao.com/v2/local/search/keyword.json?query=" + location;

            string apiKey = "b9b9c1b07ffd1a04c4047fe6f8d0f145";

            //string addr = "//dapi.kakao.com/v2/maps/sdk.js?appkey=" +apiKey;
            String query = "query=" + location;

            var req = (HttpWebRequest)WebRequest.Create(addr);
             
            req.Headers.Add("Authorization: KakaoAK " + apiKey);
            var res = (HttpWebResponse)req.GetResponse();
            var stream = res.GetResponseStream();
            var sr = new StreamReader(stream, Encoding.UTF8);

            //this.webBrowser1.DocumentText = sr.ReadToEnd();


            var j = JObject.Parse(sr.ReadToEnd());
            var itemArr = JArray.Parse(j["documents"].ToString());


            foreach (JObject item in itemArr)
            {
                map = new Map()
                {
                    Address_name = item["address_name"].ToString(),
                    Id = Int32.Parse(item["id"].ToString()),
                    Phone = item["phone"].ToString(),
                    Place_name = item["place_name"].ToString(),
                    Place_url = item["place_url"].ToString(),
                    X = item["x"].ToString(),
                    Y = item["y"].ToString()

                };
                maps.Add(map);
            }

            
            string url = "http://map.daum.net/?q=" + maps[0].Place_name + "&srcid=" + maps[0].Id + "&map_type=TYPE_MAP";

            

            Uri uri = new Uri(url);
            this.webBrowser1.Url = uri;

        }

        private void linkLabel1_Click_1(object sender, EventArgs e)
        {
            string url = linkLabel1.Text;
            Uri uri = new Uri(url);
            System.Diagnostics.Process.Start("Chrome.exe",url);
        }
    }
}
