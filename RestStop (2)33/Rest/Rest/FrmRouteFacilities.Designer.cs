namespace Rest
{
    partial class FrmRouteFacilities
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rdoSearchRoute = new System.Windows.Forms.RadioButton();
            this.rdoSearchRestName = new System.Windows.Forms.RadioButton();
            this.comBRouteName = new System.Windows.Forms.ComboBox();
            this.txtRestName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearchbyName = new System.Windows.Forms.Button();
            this.lblRestName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblConv = new System.Windows.Forms.Label();
            this.lblBatch = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblTruck = new System.Windows.Forms.Label();
            this.SearchSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoSearchRoute
            // 
            this.rdoSearchRoute.AutoSize = true;
            this.rdoSearchRoute.Location = new System.Drawing.Point(12, 12);
            this.rdoSearchRoute.Name = "rdoSearchRoute";
            this.rdoSearchRoute.Size = new System.Drawing.Size(99, 16);
            this.rdoSearchRoute.TabIndex = 0;
            this.rdoSearchRoute.TabStop = true;
            this.rdoSearchRoute.Text = "노선으로 검색";
            this.rdoSearchRoute.UseVisualStyleBackColor = true;
            this.rdoSearchRoute.CheckedChanged += new System.EventHandler(this.rdoSearchRoute_CheckedChanged);
            // 
            // rdoSearchRestName
            // 
            this.rdoSearchRestName.AutoSize = true;
            this.rdoSearchRestName.Location = new System.Drawing.Point(12, 34);
            this.rdoSearchRestName.Name = "rdoSearchRestName";
            this.rdoSearchRestName.Size = new System.Drawing.Size(139, 16);
            this.rdoSearchRestName.TabIndex = 1;
            this.rdoSearchRestName.TabStop = true;
            this.rdoSearchRestName.Text = "휴게소 이름으로 검색";
            this.rdoSearchRestName.UseVisualStyleBackColor = true;
            this.rdoSearchRestName.CheckedChanged += new System.EventHandler(this.rdoSearchRestName_CheckedChanged);
            // 
            // comBRouteName
            // 
            this.comBRouteName.FormattingEnabled = true;
            this.comBRouteName.Items.AddRange(new object[] {
            "경부선",
            "남해선",
            "무안광주ㆍ광주대구선",
            "서해안선",
            "익산포항선",
            "호남선",
            "순천완주선",
            "당진영덕선",
            "통영대전ㆍ중부선",
            "평택제천선",
            "중부내륙선",
            "영동선",
            "중앙선",
            "서울양양선",
            "동해ㆍ울산포항선",
            "서울외곽순환선",
            "남해제2지선",
            "호남선의지선",
            "서천공주선",
            "중부내륙선의지선",
            "부산외곽순환선"});
            this.comBRouteName.Location = new System.Drawing.Point(157, 12);
            this.comBRouteName.Name = "comBRouteName";
            this.comBRouteName.Size = new System.Drawing.Size(151, 20);
            this.comBRouteName.TabIndex = 2;
            this.comBRouteName.Text = "경부선";
            this.comBRouteName.SelectedValueChanged += new System.EventHandler(this.comBRouteName_SelectedValueChanged);
            // 
            // txtRestName
            // 
            this.txtRestName.Location = new System.Drawing.Point(157, 12);
            this.txtRestName.Name = "txtRestName";
            this.txtRestName.Size = new System.Drawing.Size(151, 21);
            this.txtRestName.TabIndex = 3;
            this.txtRestName.Visible = false;
            this.txtRestName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRestName_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(894, 359);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnSearchbyName
            // 
            this.btnSearchbyName.Location = new System.Drawing.Point(315, 12);
            this.btnSearchbyName.Name = "btnSearchbyName";
            this.btnSearchbyName.Size = new System.Drawing.Size(75, 23);
            this.btnSearchbyName.TabIndex = 5;
            this.btnSearchbyName.Text = "검색";
            this.btnSearchbyName.UseVisualStyleBackColor = true;
            this.btnSearchbyName.Visible = false;
            this.btnSearchbyName.Click += new System.EventHandler(this.btnSearchbyName_Click);
            // 
            // lblRestName
            // 
            this.lblRestName.AutoSize = true;
            this.lblRestName.Location = new System.Drawing.Point(93, 79);
            this.lblRestName.Name = "lblRestName";
            this.lblRestName.Size = new System.Drawing.Size(0, 12);
            this.lblRestName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "전화번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "편의시설";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "대표 음식";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "대표 매장";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "화물차 휴게소";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(107, 113);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(0, 12);
            this.lblPhone.TabIndex = 12;
            // 
            // lblConv
            // 
            this.lblConv.AutoSize = true;
            this.lblConv.Location = new System.Drawing.Point(107, 173);
            this.lblConv.Name = "lblConv";
            this.lblConv.Size = new System.Drawing.Size(0, 12);
            this.lblConv.TabIndex = 13;
            // 
            // lblBatch
            // 
            this.lblBatch.AutoSize = true;
            this.lblBatch.Location = new System.Drawing.Point(107, 220);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(0, 12);
            this.lblBatch.TabIndex = 14;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(107, 266);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(0, 12);
            this.lblBrand.TabIndex = 15;
            // 
            // lblTruck
            // 
            this.lblTruck.AutoSize = true;
            this.lblTruck.Location = new System.Drawing.Point(107, 308);
            this.lblTruck.Name = "lblTruck";
            this.lblTruck.Size = new System.Drawing.Size(0, 12);
            this.lblTruck.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmRouteFacilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 474);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTruck);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblBatch);
            this.Controls.Add(this.lblConv);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRestName);
            this.Controls.Add(this.btnSearchbyName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtRestName);
            this.Controls.Add(this.comBRouteName);
            this.Controls.Add(this.rdoSearchRestName);
            this.Controls.Add(this.rdoSearchRoute);
            this.Name = "FrmRouteFacilities";
            this.Text = "휴게소 편의시설";
            this.Load += new System.EventHandler(this.FrmRouteFacilities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoSearchRoute;
        private System.Windows.Forms.RadioButton rdoSearchRestName;
        private System.Windows.Forms.ComboBox comBRouteName;
        private System.Windows.Forms.TextBox txtRestName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearchbyName;
        private System.Windows.Forms.Label lblRestName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblConv;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblTruck;
        private System.Windows.Forms.BindingSource SearchSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}