using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RestStop
{
    class HTMLParsing
    {
        string rArea = "";
        string sDutyWeek = "";
        string sDutyTime = "";
        string rWDate = "";

        public HTMLParsing(string rArea, string sDutyWeek, string sDutyTime, string rWDate)
        {
            this.rArea = rArea;
            this.sDutyWeek = sDutyWeek;
            this.sDutyTime = sDutyTime;
            this.rWDate = rWDate;

            string url = "http://www.albamon.com/list/gi/mon_part_list.asp?ps=20&ob=6&lvtype=1&rpcd=,3180,&partExc=&" +
                "sDutyTerm=,20" + sDutyWeek + sDutyTime + rWDate + "&Empmnt_Type=";

            ParsingAlba(url);
            
        }
     

        private void ParsingAlba(string url)
        {
            Uri uri = new Uri(url);
            HttpWebRequest req = WebRequest.Create(uri) as HttpWebRequest;
            HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
            Stream stream = resp.GetResponseStream();

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(stream);
            HtmlAgilityPack.HtmlNodeCollection table = doc.DocumentNode.SelectNodes("/html[1]/body[1]/div[2]/div[2]/div[2]/div[2]/form[1]/div[5]/table[1]/tbody[1]/tr");
            DataTable datatable = new DataTable();
            datatable.Columns.Add("지역");
            datatable.Columns.Add("기업명");
            datatable.Columns.Add("모집제목");
            datatable.Columns.Add("급여");
            datatable.Columns.Add("근무시간");
            datatable.Columns.Add("등록일");

            foreach (var item in table)
            {
                foreach (var item2 in item.ChildNodes)
                {
                    DataRow row = datatable.NewRow();
                    if (item2.GetAttributeValue("class", "no") == "area")
                    {

                        string temp = item2.InnerHtml;
                        //temp.IndexOf("</span>");
                        //temp.IndexOf("<div id");
                        temp = temp.Remove(0, temp.IndexOf("</span>") + "</span>".Length);
                        temp = temp.Remove(temp.IndexOf("<div id"), temp.Length - temp.IndexOf("<div id"));
                        row["지역"] = temp;
                    }

                    if (item2.GetAttributeValue("class", "no") == "subject")
                    {
                        foreach (var item3 in item2.ChildNodes)
                        {
                            if (item3.GetAttributeValue("class", "no") == "subWrap")
                            {
                                foreach (var item4 in item3.ChildNodes)
                                {
                                    if (item4.GetAttributeValue("class", "no") == "cName")
                                    {
                                        row["기업명"] = item4.ChildNodes["a"].InnerText;
                                    }
                                    if (item4.GetAttributeValue("class", "no") == "cTit")
                                    {
                                        row["모집제목"] = item4.ChildNodes["a"].InnerText;
                                    }
                                }
                            }
                        }
                    }

                    if (item2.GetAttributeValue("class", "no") == "pay")
                    {
                        row["급여"] = item2.ChildNodes[0].ChildNodes[0].Attributes["alt"].Value + " = " + item2.ChildNodes[1].InnerText;
                    }


                    if (!item2.HasAttributes && item2.Name == "td")
                    {
                        row["근무시간"] = "시간" + item2.InnerText.Trim();
                    }

                    if (item2.GetAttributeValue("class", "no") == "recently")
                    {
                        row["등록일"] = item2.ChildNodes[0].InnerText;
                    }
                    datatable.Rows.Add(row);
                }
            }
        }

        private List<string> ParsingLocal(string url)
        {
            List<string> listLocal = new List<string>();
            Uri uri = new Uri(url);
            HttpWebRequest req = WebRequest.Create(uri) as HttpWebRequest;
            HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
            Stream stream = resp.GetResponseStream();

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(stream);
            HtmlAgilityPack.HtmlNodeCollection table = doc.DocumentNode.SelectNodes("//fieldset/div/div/ul");
            foreach (var item in table)
            {
                if (item.GetAttributeValue("class", "no") == "listLocal")
                {
                    foreach (var item2 in item.ChildNodes)
                    {
                        if (item2.HasAttributes)
                        {
                            listLocal.Add(item2.FirstChild.InnerText);
                        }

                    }

                }
            }
            return listLocal;
        }

        
    }
}
