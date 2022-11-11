using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexMold.Forms
{
    public partial class UI_SettingsPower: UserControl
    {
        public UI_SettingsPower()
        {
            InitializeComponent();
        }

        private void UI_SettingsPower_Load(object sender, EventArgs e)
        {

            //    "ErrorDate" TEXT,
            //    "ErrorTime" TEXT,
            //    "ErrorCodeName" TEXT,
            //    "ErrorDetails"  TEXT,
            //    "ErrorSource"   TEXT

                if (Class_Initializer.dictLoadErrorLogPCB_List.Count < 1)
                {
                    if (Class_Initializer.sqlite_conn.State == ConnectionState.Open)
                        Class_Initializer.ReadErrorLogsData(Class_Initializer.sqlite_conn);
                    else
                    {
                        MessageBox.Show("Database Connection Error1");
                        return;
                    }
                }
            int logRecorder = 0;
            foreach (var errElement in Class_Initializer.dictLoadErrorLogPCB_List)
            {
                logRecorder++;
                this.metroTextBox_power.Text += "*********Error Event"+logRecorder+ " with Details *********" + Environment.NewLine;
                this.metroTextBox_power.Text += "Error Date: " + errElement["ErrorDate"] +Environment.NewLine;
                this.metroTextBox_power.Text += "Error Time: " + errElement["ErrorTime"] +Environment.NewLine;
                this.metroTextBox_power.Text += "Error Code: " + errElement["ErrorCodeName"] + Environment.NewLine;
                this.metroTextBox_power.Text += "Error Details: " + errElement["ErrorDetails"] + Environment.NewLine + Environment.NewLine; ;
                //this.metroTextBox_power.Text += Environment.NewLine;
                //this.metroTextBox_power.Text += "Error Date: " + errElement["ErrorSource"];
            }
        }
    }
}
