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
    public partial class FrmProgramInfo : Form
    {
        public FrmProgramInfo()
        {
            InitializeComponent();
            lblProgramInfo.Text = "프로그램 명 : 휴게소는 언제조";// + Application.ProductName;
            lblProgramInfo.Text += "\n버전 정보 : " + Application.ProductVersion;
            lblProgramInfo.Text += "\n제작 국가 : " + Application.CurrentCulture;
            lblProgramInfo.Text += "\n";
            lblProgramInfo.Text += "\nDevelop By 임호진";//+ Application.CurrentCulture;            
            lblProgramInfo.Text += "\n                 최윤수";
            lblProgramInfo.Text += "\n                 박설화";
            lblProgramInfo.Text += "\n                 허봉권";
            //lblProgramInfo.Text += "\n데이터 경로 : " + Application.CommonAppDataPath;
        }
    }
}
