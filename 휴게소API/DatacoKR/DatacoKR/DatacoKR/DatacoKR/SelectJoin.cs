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
        private List<string> highways = new List<string>();
        string url = "";
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private static List<Map> maps = new List<Map>();

        public static List<Map> Maps { get => maps; set => maps = value; }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            highways.Clear();
            comboBox2.Items.Clear();
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

        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            maps.Clear();
            string location = comboBox2.SelectedItem.ToString();

            System.Web.HttpUtility.UrlEncode(location);
            
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

            if (maps.Count == 0)
            {
                MessageBox.Show("해당 휴게소는 지도에 존재하지 않습니다.");
                button1.Enabled = false;
            }
            else
            {
                url = "http://map.daum.net/?q=" + maps[0].Place_name + "&srcid=" + maps[0].Id + "&map_type=TYPE_MAP";
            }

            

        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null && comboBox2.SelectedItem == null)
            {
                MessageBox.Show("노선명과 휴게소명을 먼저 선택해 주세요");
            }
            else
            {
                label7.Text = maps[0].Address_name;
                label8.Text = maps[0].Phone;
                label9.Text = maps[0].Place_name;
                linkLabel1.Text = maps[0].Place_url;
                Uri uri = new Uri(url);
                this.webBrowser1.Url = uri;
               
            }
            

        }


        private void linkLabel1_Click_1(object sender, EventArgs e)
        {
            string url = linkLabel1.Text;
            Uri uri = new Uri(url);
            System.Diagnostics.Process.Start("Chrome.exe",url);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SelectJoin_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void SelectJoin_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void SelectJoin_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
