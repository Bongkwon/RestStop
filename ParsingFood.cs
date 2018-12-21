using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace FrmRestStop
{
    class ParsingFood
    {
        private DAO dao = DAO.GetInstance();
        int page = 0;

        public ParsingFood()
        {

        }
        List<Food> foods = new List<Food>();
   
        public void returnXml()
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
                if (!xml.ChildNodes[0].HasChildNodes)
                {
                    return;
                }
                foreach (XmlNode item in xml.SelectNodes("//data/list"))
                {
                    Food food = new Food();
                    foreach (XmlNode item2 in item.ChildNodes)
                    {

                        if (item2.Name == "stdRestCd")
                        {
                            food.StdRestCd = item.InnerText;
                        }
                        if (item2.Name == "stdRestNm")
                        {
                            food.StdRestNm = item.InnerText;
                        }
                        if (item2.Name == "restCd")
                        {
                            food.RestCd = item.InnerText;
                        }
                        if (item2.Name == "seq")
                        {
                            food.Seq = Int32.Parse(item.InnerText);
                        }
                        if (item2.Name == "foodNm")
                        {
                            food.FoodNm = item.InnerText;
                        }
                        if (item2.Name == "foodCost")
                        {
                            food.FoodCost = Int32.Parse(item.InnerText);
                        }
                        if (item2.Name == "seasonMenu")
                        {
                            food.SeasonMenu = item.InnerText;
                        }
                        if (item2.Name == "etc")
                        {
                            food.Etc = item.InnerText;
                        }
                        if (item2.Name == "lsttmAltrDttm")
                        {
                            food.LsttmAltrDttm = DateTime.Parse(item.InnerText);
                        }
                    }
                    foods.Add(food);
                }

                page++;
                if (page<=22)
                {
                    returnXml();
                }

            }     
        }
    }
}
