using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        

        private void CCTVDate_Load(object sender, EventArgs e)
        {
            
            string serval = "http://openapi.its.go.kr:8081/api/NCCTVInfo?key=1544770326719&ReqType=2"+"&MinX="+ (double.Parse(SelectJoin.Maps[0].X) - 0.1)+ "&MaxX="+ SelectJoin.Maps[0].X+ "&MinY="+ (double.Parse(SelectJoin.Maps[0].Y)-0.1)+ "&MaxY="+ SelectJoin.Maps[0].Y+ "&type=ex";


            //string serval = "http://openapi.its.go.kr:8081/api/NCCTVInfo?key=1544770326719&ReqType=2&MinX=127.100000&MaxX=128.890000&MinY=34.100000%20&MaxY=35.100000&type=ex";

            Uri url = new Uri(serval);
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            HttpWebResponse res = request.GetResponse() as HttpWebResponse;
            Stream stream = res.GetResponseStream();

            XmlDocument doc = new XmlDocument();
            doc.Load(stream);

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
            dataGridView1.DataSource = ct;
            //doc.SelectNodes("//data/cctvurl");
            stream.Flush();
            stream.Close();


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
    }
}
