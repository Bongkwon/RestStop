using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DatacoKR
{
    public partial class CCTVDate : Form
    {
        public CCTVDate()
        {
            InitializeComponent();
        }
        List<CCTV> ct = new List<CCTV>();
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        ConnectionJoin conn = new ConnectionJoin();
        private List<string> highways = new List<string>();
        Map map;
        private List<Map> maps = new List<Map>();
        private void CCTVDate_Load(object sender, EventArgs e)
        {

           


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0)
            {
                string url = dataGridView1.CurrentCell.Value.ToString();
                
                try
                {
                    Uri uri = new Uri(url); ;
                    
                    axWindowsMediaPlayer1.URL = uri.ToString();
                    
                }
                catch (UriFormatException)
                {
                    MessageBox.Show("해당 CCTV영상을 열 수 없습니다.");
                }
            }
        }

        private void CCTVDate_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void CCTVDate_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void CCTVDate_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
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
            button2.Enabled = true;
            maps.Clear();
            string location = comboBox2.SelectedItem.ToString();

            System.Web.HttpUtility.UrlEncode(location);
            //"https://dapi.kakao.com/v2/local/search/keyword.json?query=" + location;

            string addr = "https://dapi.kakao.com/v2/local/search/keyword.json?query=" + location;

            string apiKey = "b9b9c1b07ffd1a04c4047fe6f8d0f145";

      
            String query = "query=" + location;

            var req = (HttpWebRequest)WebRequest.Create(addr);

            req.Headers.Add("Authorization: KakaoAK " + apiKey);
            var res = (HttpWebResponse)req.GetResponse();
            var stream = res.GetResponseStream();
            var sr = new StreamReader(stream, Encoding.UTF8);

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
                button2.Enabled = false;
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {

             ct.Clear();
                dataGridView1.DataSource = null;
            string serval = "";
            try
            {
                serval = "http://openapi.its.go.kr:8081/api/NCCTVInfo?key=1544770326719&ReqType=2" + "&MinX=" + (double.Parse(maps[0].X) - 0.1) + "&MaxX=" + maps[0].X + "&MinY=" + (double.Parse(maps[0].Y) - 0.1) + "&MaxY=" + maps[0].Y + "&type=ex";
            



                Uri url = new Uri(serval);
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                HttpWebResponse ress = request.GetResponse() as HttpWebResponse;
                Stream streamm = ress.GetResponseStream();

                XmlDocument doc = new XmlDocument();
                doc.Load(streamm);

                XmlNodeList list = doc.DocumentElement.SelectNodes("//data");

                foreach (XmlNode item in list)
                {
                    CCTV cctv = new CCTV()
                    {
                        CctvUrl = item.SelectSingleNode("cctvurl").InnerText,
                        CctvName = item.SelectSingleNode("cctvname").InnerText
                    };
                    ct.Add(cctv);

                }
                if (ct.Count == 0)
                {
                    MessageBox.Show("해당 휴게소 근처 CCTV가 존재 하지 않습니다.");
                }
                dataGridView1.DataSource = ct;

                streamm.Flush();
                streamm.Close();




            }
            catch (Exception)
            {
                MessageBox.Show("선택 해주세요");
            }
        }
    }
}
