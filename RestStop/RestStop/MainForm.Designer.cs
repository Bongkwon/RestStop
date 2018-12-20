namespace RestStop
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuDropdown2 = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCheckbox2 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuCheckbox3 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuCheckbox4 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuCheckbox5 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuCheckbox6 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuCheckbox7 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCheckbox8 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCheckbox9 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCheckbox10 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCheckbox11 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCheckbox12 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCheckbox13 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCheckbox14 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCheckbox15 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCheckbox16 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 396);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 147);
            this.textBox1.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 555);
            this.panel1.TabIndex = 29;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel3;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.bunifuDropdown2);
            this.panel3.Controls.Add(this.bunifuDropdown1);
            this.panel3.Location = new System.Drawing.Point(186, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 108);
            this.panel3.TabIndex = 56;
            // 
            // panel4
            // 
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(549, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(38, 37);
            this.panel4.TabIndex = 46;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // bunifuDropdown2
            // 
            this.bunifuDropdown2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown2.BorderRadius = 3;
            this.bunifuDropdown2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown2.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown2.items = new string[] {
        "전체",
        "월~일",
        "월~토",
        "월~금",
        "토, 일",
        "주6일",
        "주5일",
        "주4일",
        "주3일",
        "주2일",
        "주1일",
        ""};
            this.bunifuDropdown2.Location = new System.Drawing.Point(276, 67);
            this.bunifuDropdown2.Name = "bunifuDropdown2";
            this.bunifuDropdown2.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuDropdown2.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuDropdown2.selectedIndex = -1;
            this.bunifuDropdown2.Size = new System.Drawing.Size(120, 32);
            this.bunifuDropdown2.TabIndex = 45;
            this.bunifuDropdown2.onItemSelected += new System.EventHandler(this.bunifuDropdown2_onItemSelected);
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.items = new string[] {
        "전국",
        "서울",
        "경기",
        "인천",
        "강원",
        "대전",
        "세종",
        "충남",
        "충북",
        "부산",
        "울산",
        "경남",
        "경북",
        "대구",
        "광주",
        "전남",
        "전북",
        "제주"};
            this.bunifuDropdown1.Location = new System.Drawing.Point(59, 67);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.SeaGreen;
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(133, 32);
            this.bunifuDropdown1.TabIndex = 31;
            this.bunifuDropdown1.onItemSelected += new System.EventHandler(this.bunifuDropdown1_onItemSelected);
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox1.Checked = false;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(219, 185);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 30;
            this.bunifuCheckbox1.Tag = "sDutyTerm=5";
            this.bunifuCheckbox1.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("D2Coding", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(245, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "하루(1일)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("D2Coding", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(245, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "1주일 이하";
            // 
            // bunifuCheckbox2
            // 
            this.bunifuCheckbox2.BackColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox2.ChechedOffColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox2.Checked = false;
            this.bunifuCheckbox2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox2.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox2.Location = new System.Drawing.Point(219, 216);
            this.bunifuCheckbox2.Name = "bunifuCheckbox2";
            this.bunifuCheckbox2.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox2.TabIndex = 33;
            this.bunifuCheckbox2.Tag = "sDutyTerm=10";
            this.bunifuCheckbox2.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("D2Coding", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(245, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 36;
            this.label3.Tag = "sDutyTerm=20";
            this.label3.Text = "1주일~1개월";
            // 
            // bunifuCheckbox3
            // 
            this.bunifuCheckbox3.BackColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox3.ChechedOffColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox3.Checked = false;
            this.bunifuCheckbox3.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox3.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox3.Location = new System.Drawing.Point(219, 248);
            this.bunifuCheckbox3.Name = "bunifuCheckbox3";
            this.bunifuCheckbox3.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox3.TabIndex = 35;
            this.bunifuCheckbox3.Tag = "sDutyTerm=20";
            this.bunifuCheckbox3.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("D2Coding", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(245, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 38;
            this.label4.Tag = "sDutyTerm=20";
            this.label4.Text = "1개월~3개월";
            // 
            // bunifuCheckbox4
            // 
            this.bunifuCheckbox4.BackColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox4.ChechedOffColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox4.Checked = false;
            this.bunifuCheckbox4.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox4.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox4.Location = new System.Drawing.Point(219, 279);
            this.bunifuCheckbox4.Name = "bunifuCheckbox4";
            this.bunifuCheckbox4.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox4.TabIndex = 37;
            this.bunifuCheckbox4.Tag = "sDutyTerm=30";
            this.bunifuCheckbox4.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("D2Coding", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(245, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 40;
            this.label5.Tag = "sDutyTerm=20";
            this.label5.Text = "3개월~6개월";
            // 
            // bunifuCheckbox5
            // 
            this.bunifuCheckbox5.BackColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox5.ChechedOffColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox5.Checked = false;
            this.bunifuCheckbox5.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox5.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox5.Location = new System.Drawing.Point(219, 309);
            this.bunifuCheckbox5.Name = "bunifuCheckbox5";
            this.bunifuCheckbox5.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox5.TabIndex = 39;
            this.bunifuCheckbox5.Tag = "sDutyTerm=40";
            this.bunifuCheckbox5.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("D2Coding", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(245, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 42;
            this.label6.Tag = "sDutyTerm=20";
            this.label6.Text = "6개월~1년";
            // 
            // bunifuCheckbox6
            // 
            this.bunifuCheckbox6.BackColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox6.ChechedOffColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox6.Checked = false;
            this.bunifuCheckbox6.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox6.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox6.Location = new System.Drawing.Point(219, 338);
            this.bunifuCheckbox6.Name = "bunifuCheckbox6";
            this.bunifuCheckbox6.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox6.TabIndex = 41;
            this.bunifuCheckbox6.Tag = "sDutyTerm=45";
            this.bunifuCheckbox6.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("D2Coding", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(245, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 44;
            this.label7.Tag = "sDutyTerm=20";
            this.label7.Text = "1년 이상";
            // 
            // bunifuCheckbox7
            // 
            this.bunifuCheckbox7.BackColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox7.ChechedOffColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox7.Checked = false;
            this.bunifuCheckbox7.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox7.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox7.Location = new System.Drawing.Point(219, 368);
            this.bunifuCheckbox7.Name = "bunifuCheckbox7";
            this.bunifuCheckbox7.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox7.TabIndex = 43;
            this.bunifuCheckbox7.Tag = "sDutyTerm=48";
            this.bunifuCheckbox7.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            // 
            // bunifuCheckbox8
            // 
            this.bunifuCheckbox8.BackColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox8.ChechedOffColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox8.Checked = false;
            this.bunifuCheckbox8.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox8.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox8.Location = new System.Drawing.Point(462, 185);
            this.bunifuCheckbox8.Name = "bunifuCheckbox8";
            this.bunifuCheckbox8.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox8.TabIndex = 46;
            this.bunifuCheckbox8.Tag = "sDutyTerm=48";
            this.bunifuCheckbox8.OnChange += new System.EventHandler(this.bunifuCheckbox8_OnChange);
            // 
            // bunifuCheckbox9
            // 
            this.bunifuCheckbox9.BackColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox9.ChechedOffColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox9.Checked = false;
            this.bunifuCheckbox9.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox9.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox9.Location = new System.Drawing.Point(462, 216);
            this.bunifuCheckbox9.Name = "bunifuCheckbox9";
            this.bunifuCheckbox9.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox9.TabIndex = 47;
            this.bunifuCheckbox9.Tag = "sDutyTerm=48";
            this.bunifuCheckbox9.OnChange += new System.EventHandler(this.bunifuCheckbox8_OnChange);
            // 
            // bunifuCheckbox10
            // 
            this.bunifuCheckbox10.BackColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox10.ChechedOffColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox10.Checked = false;
            this.bunifuCheckbox10.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox10.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox10.Location = new System.Drawing.Point(462, 248);
            this.bunifuCheckbox10.Name = "bunifuCheckbox10";
            this.bunifuCheckbox10.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox10.TabIndex = 48;
            this.bunifuCheckbox10.Tag = "sDutyTerm=48";
            this.bunifuCheckbox10.OnChange += new System.EventHandler(this.bunifuCheckbox8_OnChange);
            // 
            // bunifuCheckbox11
            // 
            this.bunifuCheckbox11.BackColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox11.ChechedOffColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox11.Checked = false;
            this.bunifuCheckbox11.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox11.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox11.Location = new System.Drawing.Point(462, 279);
            this.bunifuCheckbox11.Name = "bunifuCheckbox11";
            this.bunifuCheckbox11.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox11.TabIndex = 49;
            this.bunifuCheckbox11.Tag = "sDutyTerm=48";
            this.bunifuCheckbox11.OnChange += new System.EventHandler(this.bunifuCheckbox8_OnChange);
            // 
            // bunifuCheckbox12
            // 
            this.bunifuCheckbox12.BackColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox12.ChechedOffColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox12.Checked = false;
            this.bunifuCheckbox12.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox12.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox12.Location = new System.Drawing.Point(462, 309);
            this.bunifuCheckbox12.Name = "bunifuCheckbox12";
            this.bunifuCheckbox12.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox12.TabIndex = 50;
            this.bunifuCheckbox12.Tag = "sDutyTerm=48";
            this.bunifuCheckbox12.OnChange += new System.EventHandler(this.bunifuCheckbox8_OnChange);
            // 
            // bunifuCheckbox13
            // 
            this.bunifuCheckbox13.BackColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox13.ChechedOffColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox13.Checked = false;
            this.bunifuCheckbox13.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox13.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox13.Location = new System.Drawing.Point(462, 338);
            this.bunifuCheckbox13.Name = "bunifuCheckbox13";
            this.bunifuCheckbox13.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox13.TabIndex = 51;
            this.bunifuCheckbox13.Tag = "sDutyTerm=48";
            this.bunifuCheckbox13.OnChange += new System.EventHandler(this.bunifuCheckbox8_OnChange);
            // 
            // bunifuCheckbox14
            // 
            this.bunifuCheckbox14.BackColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox14.ChechedOffColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox14.Checked = false;
            this.bunifuCheckbox14.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox14.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox14.Location = new System.Drawing.Point(462, 368);
            this.bunifuCheckbox14.Name = "bunifuCheckbox14";
            this.bunifuCheckbox14.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox14.TabIndex = 52;
            this.bunifuCheckbox14.Tag = "sDutyTerm=48";
            this.bunifuCheckbox14.OnChange += new System.EventHandler(this.bunifuCheckbox8_OnChange);
            // 
            // bunifuCheckbox15
            // 
            this.bunifuCheckbox15.BackColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox15.ChechedOffColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox15.Checked = false;
            this.bunifuCheckbox15.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox15.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox15.Location = new System.Drawing.Point(462, 397);
            this.bunifuCheckbox15.Name = "bunifuCheckbox15";
            this.bunifuCheckbox15.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox15.TabIndex = 53;
            this.bunifuCheckbox15.Tag = "sDutyTerm=48";
            this.bunifuCheckbox15.OnChange += new System.EventHandler(this.bunifuCheckbox8_OnChange);
            // 
            // bunifuCheckbox16
            // 
            this.bunifuCheckbox16.BackColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox16.ChechedOffColor = System.Drawing.Color.Gray;
            this.bunifuCheckbox16.Checked = false;
            this.bunifuCheckbox16.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox16.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox16.Location = new System.Drawing.Point(462, 425);
            this.bunifuCheckbox16.Name = "bunifuCheckbox16";
            this.bunifuCheckbox16.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox16.TabIndex = 54;
            this.bunifuCheckbox16.Tag = "sDutyTerm=48";
            this.bunifuCheckbox16.OnChange += new System.EventHandler(this.bunifuCheckbox8_OnChange);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(186, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 450);
            this.panel2.TabIndex = 55;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("D2Coding", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(297, 321);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 19);
            this.label16.TabIndex = 65;
            this.label16.Text = "풀타임";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("D2Coding", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(297, 293);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 19);
            this.label15.TabIndex = 64;
            this.label15.Text = "새벽~오전";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("D2Coding", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(297, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 19);
            this.label14.TabIndex = 63;
            this.label14.Text = "저녁~새벽";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("D2Coding", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(297, 233);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 19);
            this.label13.TabIndex = 62;
            this.label13.Text = "오후~저녁";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("D2Coding", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(297, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 19);
            this.label12.TabIndex = 61;
            this.label12.Text = "오전~오후";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("D2Coding", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(297, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 19);
            this.label11.TabIndex = 60;
            this.label11.Text = "새벽";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("D2Coding", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(297, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 19);
            this.label10.TabIndex = 59;
            this.label10.Text = "저녁";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("D2Coding", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(297, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 19);
            this.label9.TabIndex = 58;
            this.label9.Text = "오후";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("D2Coding", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(297, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 19);
            this.label8.TabIndex = 57;
            this.label8.Text = "오전";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("D2Coding", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(12, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 19);
            this.label17.TabIndex = 57;
            this.label17.Text = "지역";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("D2Coding", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(213, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 19);
            this.label18.TabIndex = 58;
            this.label18.Text = "기간텀";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 555);
            this.Controls.Add(this.bunifuCheckbox16);
            this.Controls.Add(this.bunifuCheckbox15);
            this.Controls.Add(this.bunifuCheckbox14);
            this.Controls.Add(this.bunifuCheckbox13);
            this.Controls.Add(this.bunifuCheckbox12);
            this.Controls.Add(this.bunifuCheckbox11);
            this.Controls.Add(this.bunifuCheckbox10);
            this.Controls.Add(this.bunifuCheckbox9);
            this.Controls.Add(this.bunifuCheckbox8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bunifuCheckbox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bunifuCheckbox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuCheckbox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunifuCheckbox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuCheckbox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuCheckbox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuCheckbox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox7;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox8;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox9;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox10;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox11;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox12;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox13;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox14;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox15;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox16;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
    }
}

