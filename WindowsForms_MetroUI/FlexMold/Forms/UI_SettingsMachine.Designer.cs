namespace FlexMold.Forms
{
    partial class UI_SettingsMachine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_Size = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_Radius = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_MTCnt = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_PrtProduced = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_OpTime = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(32, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Size";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 51);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(107, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Minimum Radius";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(13, 94);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Motor Count";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(13, 137);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(99, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Parts Produced";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(13, 177);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(116, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Time In Operation";
            // 
            // metroTextBox_Size
            // 
            this.metroTextBox_Size.Location = new System.Drawing.Point(184, 10);
            this.metroTextBox_Size.Name = "metroTextBox_Size";
            this.metroTextBox_Size.Size = new System.Drawing.Size(121, 23);
            this.metroTextBox_Size.TabIndex = 11;
            // 
            // metroTextBox_Radius
            // 
            this.metroTextBox_Radius.Location = new System.Drawing.Point(184, 47);
            this.metroTextBox_Radius.Name = "metroTextBox_Radius";
            this.metroTextBox_Radius.Size = new System.Drawing.Size(121, 23);
            this.metroTextBox_Radius.TabIndex = 12;
            // 
            // metroTextBox_MTCnt
            // 
            this.metroTextBox_MTCnt.Location = new System.Drawing.Point(184, 90);
            this.metroTextBox_MTCnt.Name = "metroTextBox_MTCnt";
            this.metroTextBox_MTCnt.Size = new System.Drawing.Size(121, 23);
            this.metroTextBox_MTCnt.TabIndex = 13;
            // 
            // metroTextBox_PrtProduced
            // 
            this.metroTextBox_PrtProduced.Location = new System.Drawing.Point(184, 133);
            this.metroTextBox_PrtProduced.Name = "metroTextBox_PrtProduced";
            this.metroTextBox_PrtProduced.Size = new System.Drawing.Size(121, 23);
            this.metroTextBox_PrtProduced.TabIndex = 14;
            // 
            // metroTextBox_OpTime
            // 
            this.metroTextBox_OpTime.Location = new System.Drawing.Point(184, 173);
            this.metroTextBox_OpTime.Name = "metroTextBox_OpTime";
            this.metroTextBox_OpTime.Size = new System.Drawing.Size(121, 23);
            this.metroTextBox_OpTime.TabIndex = 15;
            // 
            // UI_SettingsMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTextBox_OpTime);
            this.Controls.Add(this.metroTextBox_PrtProduced);
            this.Controls.Add(this.metroTextBox_MTCnt);
            this.Controls.Add(this.metroTextBox_Radius);
            this.Controls.Add(this.metroTextBox_Size);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UI_SettingsMachine";
            this.Size = new System.Drawing.Size(327, 224);
            this.Load += new System.EventHandler(this.UI_SettingsMachine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Size;
        private MetroFramework.Controls.MetroTextBox metroTextBox_Radius;
        private MetroFramework.Controls.MetroTextBox metroTextBox_MTCnt;
        private MetroFramework.Controls.MetroTextBox metroTextBox_PrtProduced;
        private MetroFramework.Controls.MetroTextBox metroTextBox_OpTime;
    }
}
