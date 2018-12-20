using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using HtmlAgilityPack;


namespace Rest
{
    public partial class FrmGasStation : Form
    {        
        int pageIndex = 0;
        List<GasStation> lstGas = new List<GasStation>();
        List<GasStation> lstGasStation = new List<GasStation>();

        public FrmGasStation()
        {
            InitializeComponent();
        }

        private void FrmGasStation_Load(object sender, EventArgs e)
        {            
            this.ContextMenuStrip = new Form1().contextMenuStrip1;
            this.BackColor = Color.Gray;
            
            rdoSearchByRoute.Checked = true;
            //rdoSearchByReststop.Text = "경부선";
            bool toggle = true;
            int i = 1;
            try
            {
                while (toggle)
                {
                    WebRequest request = WebRequest.Create("http://www.roadplus.co.kr/gasStation.do?page=" + i);
                    i++;
                    WebResponse response = request.GetResponse();
                    Stream stream = response.GetResponseStream();
                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    doc.Load(stream, Encoding.UTF8, true);
                    //doc.Save(stream, Encoding.Default);


                    HtmlNode root = doc.DocumentNode;
                    foreach (HtmlNode item in root.SelectNodes("//tbody/tr"))
                    {
                        string highwayName = "";
                        string restStopName = "";
                        string lpgPrice = "";
                        string gasolinePrice = "";
                        string dieselPrice = "";
                        //textBox1.Text += item.InnerText;

                        highwayName = item.SelectNodes("td")[0].InnerText.Replace("X", "").Trim();
                        restStopName = item.SelectNodes("td/input")[0].Attributes["value"].Value.Replace("X", "").Trim();
                        dieselPrice = item.SelectNodes("td")[3].InnerText.Replace("X", "").Trim();
                        gasolinePrice = item.SelectNodes("td")[4].InnerText.Replace("X", "").Trim();
                        lpgPrice = item.SelectNodes("td")[5].InnerText.Replace("X", "").Trim();

                        lstGas.Add(new GasStation(highwayName, restStopName, lpgPrice, gasolinePrice, dieselPrice));
                        //textBox1.Text += item.SelectNodes("td")[0].InnerText;
                        response.Close();

                    }
                    //textBox1.Text = doc.Text;
                }
            }
            catch (Exception)
            {
                toggle = false;
            }
            //dataGridView1.DataSource = lstGas;

            string temp = "";
            for (int j = 0; j < lstGas.Count-1; j++)
            {
                if (lstGas[j].HighwayName != temp)
                {
                    cmbRoute.Items.Add(lstGas[j].HighwayName);
                    cmbRoute.AutoCompleteCustomSource.Add(lstGas[j].HighwayName);
                    temp = lstGas[j].HighwayName;                    
                }
                txtSearchByName.AutoCompleteCustomSource.Add(lstGas[j].RestStopName);
            }
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cmbRoute.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbRoute.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSearchByName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearchByName.AutoCompleteMode = AutoCompleteMode.Suggest;

            //button1_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            Search();
        }

        private void rdoSearchByRoute_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSearchByRoute.Checked == true)
            {
                txtSearchByName.Visible = false;
                cmbRoute.Visible = true;
            }
            else
            {
                txtSearchByName.Visible = true;
                cmbRoute.Visible = false;
            }
        }
        
        public void Search()
        {            
            pageIndex = 0;
            lstGasStation.Clear();
            lstGasStation = new List<GasStation>();
            if (rdoSearchByReststop.Checked == true)
            {
                foreach (var item in lstGas)
                {
                    if (item.RestStopName.Substring(0, item.RestStopName.IndexOf('(')).Contains(txtSearchByName.Text)) 
                    {
                        lstGasStation.Add(item);
                    }
                }
            }
            else if (rdoSearchByRoute.Checked == true)
            {
                foreach (var item in lstGas)
                {
                    if (item.HighwayName.Contains(cmbRoute.SelectedItem.ToString()))
                    {
                        lstGasStation.Add(item);
                    }
                }
            }
            Display();
        }

        private void Display()
        {
            try
            {
                lblRestName.Text = lstGasStation[pageIndex].RestStopName;
                lblLpgPrice.Text = lstGasStation[pageIndex].LpgPrice;
                lblGasolinePrice.Text = lstGasStation[pageIndex].GasolinePrice;
                lblDieselPrice.Text = lstGasStation[pageIndex].DieselPrice;
            }
            catch (Exception)
            {
                MessageBox.Show("없는 데이터 입니다.");
            }
        }

        private void txtSearchByName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
            else if (e.KeyCode == Keys.Right)
            {
                button2_Click(null, null);
            }
            else if (e.KeyCode == Keys.Left)
            {
                button3_Click(null, null);
            }
        }

        private void cmbRoute_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
            else if(e.KeyCode == Keys.Right)
            {
                button2_Click(null, null);
            }
            else if(e.KeyCode == Keys.Left)
            {
                button3_Click(null, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pageIndex < lstGasStation.Count - 1)
            {
                pageIndex++;
                Display();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pageIndex > 0)
            {
                pageIndex--;
                Display();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
