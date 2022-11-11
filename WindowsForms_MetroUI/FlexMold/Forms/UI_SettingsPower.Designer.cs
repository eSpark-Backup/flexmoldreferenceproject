namespace FlexMold.Forms
{
    partial class UI_SettingsPower
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
            this.metroTextBox_power = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroTextBox_power
            // 
            this.metroTextBox_power.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTextBox_power.Location = new System.Drawing.Point(0, 0);
            this.metroTextBox_power.Multiline = true;
            this.metroTextBox_power.Name = "metroTextBox_power";
            this.metroTextBox_power.Size = new System.Drawing.Size(504, 418);
            this.metroTextBox_power.TabIndex = 0;
            this.metroTextBox_power.Text = "";
            // 
            // UI_SettingsPower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTextBox_power);
            this.Name = "UI_SettingsPower";
            this.Size = new System.Drawing.Size(504, 418);
            this.Load += new System.EventHandler(this.UI_SettingsPower_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox_power;
    }
}
