using FrmRestStop;
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

namespace RestStopForProject
{
    public partial class FrmFood : Form
    {
        Food food;
        int page = 0;
        int ret;
        public FrmFood()
        { 
            InitializeComponent();
        }

        //ParsingFood parsingFood = new ParsingFood();
        List<Food> foods = new List<Food>();
        private void FrmFood_Load(object sender, EventArgs e)
        {
            string result = "";
            string serviceKey = "3iES5fXoHGRhawYVET5MPLZxn9wG5L1rmt5eJC4PTouVi%2FUinMTvXrEr0m1b%2BQXXfcNdp6vgqgpU79u2ZktXJg%3D%3D";
            string servelUrl = "http://data.ex.co.kr/exopenapi/restinfo/restBestfoodList?type=xml&numOfRows=99&pageNo=" + page + "&ServiceKey=" + serviceKey;

            var req = (HttpWebRequest)WebRequest.Create(servelUrl);
            var res = (HttpWebResponse)req.GetResponse();


            if (res.StatusCode == HttpStatusCode.OK)
            {
                var stream = res.GetResponseStream();
                var sr = new StreamReader(stream, Encoding.UTF8);
                result += sr.ReadToEnd().Replace("</b>", "").Replace("<b>", "");
                XmlDocument xml = new XmlDocument();
                xml.Load(servelUrl);
                if (xml.SelectNodes("//data/list").Count == 0)
                {

                    FrmFood_Load(null, null);
                }
                foreach (XmlNode item in xml.SelectNodes("//data/list"))
                {

                    food = new Food();


                    foreach (XmlNode item2 in item.ChildNodes)
                    {

                        if (item2.Name == "stdRestCd")
                        {
                            food.StdRestCd = item2.InnerText;
                        }
                        if (item2.Name == "stdRestNm")
                        {
                            food.StdRestNm = item2.InnerText;
                        }
                        if (item2.Name == "restCd")
                        {
                            food.RestCd = item2.InnerText;
                        }
                        if (item2.Name == "seq")
                        {
                            food.Seq = Int32.Parse(item2.InnerText);
                        }
                        if (item2.Name == "foodNm")
                        {
                            food.FoodNm = item2.InnerText;
                        }
                        if (item2.Name == "foodCost")
                        {
                            try
                            {
                                food.FoodCost = Int32.Parse(item2.InnerText);
                            }
                            catch (FormatException ew)
                            {
                                MessageBox.Show(ew.Message);
                            }
                        }
                        if (item2.Name == "seasonMenu")
                        {
                            food.SeasonMenu = item2.InnerText;
                        }
                        if (item2.Name == "etc")
                        {
                            food.Etc = item2.InnerText;
                        }
                        if (item2.Name == "lsttmAltrDttm")
                        {
                            food.LsttmAltrDttm = DateTime.Parse(item2.InnerText);
                        }
                    }
                    foods.Add(food);

                }

                page++;
                if (page < 22)
                {
                    FrmFood_Load(null, null);
                }
            }
            this.dataGridView1.DataSource = foods;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool res = false;
            List<Food> lstf = new List<Food>();
            List<Food> lstr = new List<Food>();
            if (radioButton1.Checked == true)
            {
                foreach (var item in foods)
                {
                    if (item.FoodNm.Contains(textBox1.Text))
                    {
                        lstf.Add(item);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = lstf;
                        res = true;
                    }
                    
                }
                if (!res)
                {
                    MessageBox.Show("찾는 음식이 없습니다");
                }
            }
            if (radioButton2.Checked == true)
            {
                foreach (var item in foods)
                {
                    if (item.StdRestNm.Contains(textBox1.Text))
                    {
                        lstr.Add(item);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = lstr;
                        res = true;
                    }
                }
                if (!res)
                {
                    MessageBox.Show("찾는 휴게소가 없습니다");
                }
            }

        }
    }
}



