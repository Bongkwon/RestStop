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
using Bunifu;

namespace RestStop
{
    public partial class MainForm : Form
    {
        private string sDutyWeek ="";
        private string sDutyTime = "";
        private string sDutyTerm = "";
        private string rWDate = "";
        private string rArea = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string url = "http://www.albamon.com/list/gi/mon_part_list.asp?ps=20&ob=6&lvtype=1&rpcd=,3180,&partExc=&" +
            "sDutyTerm=,20" + sDutyWeek + sDutyTime + rWDate + "&Empmnt_Type=";

            Uri uri = new Uri(url);
            HttpWebRequest req = WebRequest.Create(uri) as HttpWebRequest;
            HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
            Stream stream = resp.GetResponseStream();

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(stream);
            HtmlAgilityPack.HtmlNodeCollection table = doc.DocumentNode.SelectNodes("//fieldset/div");
        }

        private void bunifuCheckbox8_OnChange(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuCheckbox chk = (Bunifu.Framework.UI.BunifuCheckbox)sender;
               sDutyTime = (string)chk.Tag;
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuDropdown dwn = (Bunifu.Framework.UI.BunifuDropdown)sender;
            string[] areacode = { "Q", "I", "B", "K", "A", "G", "1", "O", "P", "H", "J", "C", "D", "F", "E", "L", "M", "N" };
            for (int i = 0; i < dwn.items.Length; i++)
            {
                if (dwn.selectedIndex == i)
                {
                    rArea = "rArea=," + areacode[i] + "000";
                }
            }
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuCheckbox chk = (Bunifu.Framework.UI.BunifuCheckbox)sender;
            sDutyTerm = (string)chk.Tag;
        }

        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuDropdown dwn = (Bunifu.Framework.UI.BunifuDropdown)sender;
            string[] Weekcode = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            for (int i = 1; i < dwn.items.Length; i++)
            {
                if (dwn.selectedIndex == i)
                {
                    sDutyWeek = "sDutyWeek=," + Weekcode[i] + "000";
                }
            }
            textBox1.Text = (string)sender;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Close();
        }
    }
}
