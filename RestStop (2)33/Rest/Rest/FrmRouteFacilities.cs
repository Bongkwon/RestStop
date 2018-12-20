using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rest
{
    public partial class FrmRouteFacilities : Form
    {
        List<SearchResultByRestName> lstResult = new List<SearchResultByRestName>();
        int i = 0;
        public FrmRouteFacilities()
        {
            InitializeComponent();
        }

        private void FrmRouteFacilities_Load(object sender, EventArgs e)
        {
            SearchByRoute("경부선");
            VisibleControl(false);
        }



        #region 라디오 버튼 클릭시 이벤트
        private void rdoSearchRestName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSearchRestName.Checked == true)
            {
                txtRestName.Visible = true;
                comBRouteName.Visible = false;
                btnSearchbyName.Visible = true;               
            }
            else
            {
                txtRestName.Visible = false;
                comBRouteName.Visible = true;
                btnSearchbyName.Visible = false;
                comBRouteName_SelectedValueChanged(null, null);
            }
        }
        #endregion

        private void comBRouteName_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comBRouteName.SelectedItem.ToString());
            //dataGridView1.Visible = true;
            SearchByRoute(comBRouteName.SelectedItem.ToString());
            VisibleControl(false);
        }

        private void VisibleControl(bool b)
        {
            dataGridView1.Visible = !b;
            button1.Visible = b;
            button2.Visible = b;
            label1.Visible = b;
            label2.Visible = b;
            label3.Visible = b;
            label4.Visible = b;
            label5.Visible = b;
            lblBatch.Visible = b;
            lblBrand.Visible = b;
            lblConv.Visible = b;
            lblPhone.Visible = b;
            lblRestName.Visible = b;
            lblTruck.Visible = b;
        }

        private void SearchByRoute(string v)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("휴게소명");
            dt.Columns.Add("전화번호");
            dt.Columns.Add("편의시설");
            dt.Columns.Add("대표음식");
            dt.Columns.Add("대표 매장");
            dt.Columns.Add("화물차 휴게소");
            //dt.Columns.Add("휴게소명");
            foreach (var item in Form1.lstRoute)
            {
                
                if (item.RouteName == v)
                {
                    DataRow dr = dt.NewRow();
                    dr["휴게소명"] = item.ServiceAreaName + " (" + item.Direction + ")";
                    dr["전화번호"] = item.TelNo;
                    dr["편의시설"] = item.Convenience.TrimEnd('|').Replace("|", ", ");
                    dr["대표음식"] = item.BatchMenu;                    
                    if (item.Brand.Length>1)
                    {
                        if (item.Brand.Contains("외"))
                        {
                            dr["대표 매장"] = item.Brand.Remove(item.Brand.IndexOf("외"));
                        }
                    }
                    dr["화물차 휴게소"] = item.TruckSaYn;                                        
                    dt.Rows.Add(dr);
                }
            }
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            //dataGridView1.Height = dataGridView1.Rows.GetRowsHeight(DataGridViewElementStates.Selected);
            dataGridView1.Columns["화물차 휴게소"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void txtRestName_KeyDown(object sender, KeyEventArgs e)
        {
            
            
            if(e.KeyCode == Keys.Enter)
            {
                lblRestName.DataBindings.Clear();
                lstResult.Clear();
                if (string.IsNullOrWhiteSpace(txtRestName.Text) == false)
                {
                    foreach (var item in Form1.lstRoute)
                    {
                        if(item.ServiceAreaName.Contains(txtRestName.Text))
                        {
                            lstResult.Add(new SearchResultByRestName(item.ServiceAreaName + "휴게소" + " (" + item.Direction + ")", item.BatchMenu, item.Brand, item.Convenience, item.TelNo, item.TruckSaYn));
                            //lblRestName.Text = item.ServiceAreaName + "휴게소" + " (" + item.Direction + ")";
                            //lblBatch.Text = item.BatchMenu;
                            //lblBrand.Text = item.Brand;
                            //lblConv.Text = item.Convenience;
                            //lblPhone.Text = item.TelNo;
                            //lblTruck.Text = item.TruckSaYn;
                        }
                    }
                    
                    if (lstResult.Count > 0)
                    {
                        i = 0;
                        printLabel(i);
                        //dataGridView1.Visible = false;
                        VisibleControl(true);
                        //SearchSource.DataSource = lstResult;
                        //lblRestName.DataBindings.Add("Text", SearchSource, "serviceAreaName");
                        //bindingNavigator1.BindingSource = SearchSource;                        
                    }                    
                    else
                    {
                        MessageBox.Show("없는 휴게소 입니다.");
                        button1.Enabled = false;
                        button2.Enabled = false;
                        i = 0;
                    }
                }
                else
                {
                    MessageBox.Show("값을 입력 해주세요.");
                }
                
            }
            if(e.KeyCode == Keys.Left)
            {
                button1_Click(null, null);
            }
            if (e.KeyCode == Keys.Right)
            {
                button2_Click(null, null);
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (i < lstResult.Count() - 1)
            {
                i++;
                printLabel(i);
                lblBatch.Text = lstResult[i].BatchMenu;
            }
            else
            {
                MessageBox.Show("마지막입니다.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                printLabel(i);

            }
            else
            {
                MessageBox.Show("처음입니다.");
            }
        }

        private void printLabel(int i)
        {
            lblRestName.Text = lstResult[i].ServiceAreaName;
            lblTruck.Text = lstResult[i].TruckSaYn;
            lblPhone.Text = lstResult[i].TelNo;
            lblConv.Text = lstResult[i].Convenience.TrimEnd('|').Replace("|", ", ");
            if (lstResult[i].Brand.Contains("외"))
            {
                lblBrand.Text = lstResult[i].Brand.Remove(lstResult[i].Brand.IndexOf("외"));
            }
            else
            {
                lblBrand.Text = "";
            }
            lblBatch.Text = lstResult[i].BatchMenu;
        }

        private void btnSearchbyName_Click(object sender, EventArgs e)
        {
            txtRestName_KeyDown(null, new KeyEventArgs(Keys.Enter));
        }

        private void rdoSearchRoute_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}