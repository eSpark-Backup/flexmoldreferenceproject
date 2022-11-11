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
    public partial class UI_SettingsMachine : UserControl
    {
        public UI_SettingsMachine()
        {
            InitializeComponent();
        }

        private void UI_SettingsMachine_Load(object sender, EventArgs e)
        {
            if (Class_Initializer.dictLoadDataMainSettings.Count < 1)
            {
                if (Class_Initializer.sqlite_conn.State == ConnectionState.Open)
                    Class_Initializer.ReadMainSettingsData(Class_Initializer.sqlite_conn);
                else
                {
                    MessageBox.Show("Database Connection Error1");
                    return;
                }
            }

                this.metroTextBox_Size.Text = Class_Initializer.dictLoadDataMainSettings["InfoSize"].ToString();
                this.metroTextBox_Radius.Text = Class_Initializer.dictLoadDataMainSettings["InfoMinRadius"].ToString();
                this.metroTextBox_MTCnt.Text = Class_Initializer.dictLoadDataMainSettings["InfoMotorCnt"].ToString();
                this.metroTextBox_OpTime.Text = Class_Initializer.dictLoadDataMainSettings["InfoTotalOperTime"].ToString();
                this.metroTextBox_PrtProduced.Text = Class_Initializer.dictLoadDataMainSettings["InfoPartsProduced"].ToString();
            
        }
    }
}
