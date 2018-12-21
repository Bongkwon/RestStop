namespace Rest
{
    partial class FrmProgramInfo
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
            this.lblProgramInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProgramInfo
            // 
            this.lblProgramInfo.AutoSize = true;
            this.lblProgramInfo.Location = new System.Drawing.Point(13, 13);
            this.lblProgramInfo.Name = "lblProgramInfo";
            this.lblProgramInfo.Size = new System.Drawing.Size(0, 12);
            this.lblProgramInfo.TabIndex = 0;
            // 
            // FrmProgramInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 187);
            this.Controls.Add(this.lblProgramInfo);
            this.Name = "FrmProgramInfo";
            this.Text = "프로그램 정보";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProgramInfo;
    }
}