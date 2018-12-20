using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rest
{
    public partial class Form1 : Form
    {
        internal static List<RouteFac> lstRoute = new List<RouteFac>();
        internal static List<RestStopFac> lstRestStop = new List<RestStopFac>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new FrmRestStopFacilities().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ContextMenuStrip = contextMenuStrip1;
            panel1.BackColor = Color.FromArgb(0, 0, 0, 0); // 패널을 투명한 색으로 바꿈 
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SelectAllInRestStop";
                con.Open();
                var datas = cmd.ExecuteReader();
                while (datas.Read())
                {
                    lstRestStop.Add(new RestStopFac(datas["batchMenu"].ToString(), datas["brand"].ToString(), datas["convenience"].ToString(), datas["direction"].ToString(), datas["serviceAreaCode"].ToString(), datas["serviceAreaName"].ToString(), datas["telNo"].ToString(), datas["truckSaYn"].ToString()));
                }
                con.Close();

                con.Open();
                cmd.CommandText = "SelectAllInRoute";
                datas = cmd.ExecuteReader();
                while (datas.Read())
                {
                    lstRoute.Add(new RouteFac(datas["batchMenu"].ToString(), datas["brand"].ToString(), datas["convenience"].ToString(), datas["direction"].ToString(), datas["serviceAreaCode"].ToString(), datas["serviceAreaName"].ToString(), datas["telNo"].ToString(), datas["truckSaYn"].ToString(), datas["routeName"].ToString()));
                }
                con.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FrmRouteFacilities().Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new FrmGasStation().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료 하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            var s = sender as Panel;
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
                return;

            s.Parent.Left = this.Left + (e.X - ((Point)s.Tag).X);
            s.Parent.Top = this.Top + (e.Y - ((Point)s.Tag).Y);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            var s = sender as Panel;
            s.Tag = new Point(e.X, e.Y);
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료 하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.None)== DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
