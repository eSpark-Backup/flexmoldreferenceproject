namespace FlexMold.Forms
{
    partial class UI_SettingsMotor

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
            this.UI_SettingsPowerGroupBox1 = new System.Windows.Forms.GroupBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroBtnSearch = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxRangeTo = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxRangeFrom = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.UI_SettingsPowerGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_SettingsPowerGroupBox1
            // 
            this.UI_SettingsPowerGroupBox1.Controls.Add(this.metroTextBox2);
            this.UI_SettingsPowerGroupBox1.Controls.Add(this.metroBtnSearch);
            this.UI_SettingsPowerGroupBox1.Controls.Add(this.metroTextBoxRangeTo);
            this.UI_SettingsPowerGroupBox1.Controls.Add(this.metroTextBoxRangeFrom);
            this.UI_SettingsPowerGroupBox1.Controls.Add(this.metroLabel1);
            this.UI_SettingsPowerGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UI_SettingsPowerGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.UI_SettingsPowerGroupBox1.Name = "UI_SettingsPowerGroupBox1";
            this.UI_SettingsPowerGroupBox1.Size = new System.Drawing.Size(327, 224);
            this.UI_SettingsPowerGroupBox1.TabIndex = 0;
            this.UI_SettingsPowerGroupBox1.TabStop = false;
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroTextBox2.Location = new System.Drawing.Point(3, 54);
            this.metroTextBox2.Multiline = true;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.ReadOnly = true;
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroTextBox2.Size = new System.Drawing.Size(321, 167);
            this.metroTextBox2.TabIndex = 15;
            this.metroTextBox2.Text = "Ranges Not Responding!";
            // 
            // metroBtnSearch
            // 
            this.metroBtnSearch.Location = new System.Drawing.Point(271, 16);
            this.metroBtnSearch.Name = "metroBtnSearch";
            this.metroBtnSearch.Size = new System.Drawing.Size(41, 23);
            this.metroBtnSearch.TabIndex = 14;
            this.metroBtnSearch.Text = "Search";
            this.metroBtnSearch.Click += new System.EventHandler(this.metroBtnSearch_Click);
            // 
            // metroTextBoxRangeTo
            // 
            this.metroTextBoxRangeTo.Location = new System.Drawing.Point(190, 16);
            this.metroTextBoxRangeTo.MaxLength = 3;
            this.metroTextBoxRangeTo.Name = "metroTextBoxRangeTo";
            this.metroTextBoxRangeTo.Size = new System.Drawing.Size(75, 23);
            this.metroTextBoxRangeTo.TabIndex = 13;
            this.metroTextBoxRangeTo.Text = "450";
            // 
            // metroTextBoxRangeFrom
            // 
            this.metroTextBoxRangeFrom.Location = new System.Drawing.Point(109, 16);
            this.metroTextBoxRangeFrom.MaxLength = 3;
            this.metroTextBoxRangeFrom.Name = "metroTextBoxRangeFrom";
            this.metroTextBoxRangeFrom.Size = new System.Drawing.Size(75, 23);
            this.metroTextBoxRangeFrom.TabIndex = 12;
            this.metroTextBoxRangeFrom.Text = "1";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Motor Count";
            // 
            // UI_SettingsMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UI_SettingsPowerGroupBox1);
            this.Name = "UI_SettingsMotor";
            this.Size = new System.Drawing.Size(327, 224);
            this.UI_SettingsPowerGroupBox1.ResumeLayout(false);
            this.UI_SettingsPowerGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UI_SettingsPowerGroupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroBtnSearch;
        private MetroFramework.Controls.MetroTextBox metroTextBoxRangeTo;
        private MetroFramework.Controls.MetroTextBox metroTextBoxRangeFrom;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
    }
}
