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
    public partial class UI_SettingsMotor: UserControl
    {
        public UI_SettingsMotor()
        {
            InitializeComponent();
            this.metroTextBox2.Text = "Motors Not Responding...     Found 25,38,144"+Environment.NewLine + Environment.NewLine;
            this.metroTextBox2.Text += "=============================================" + Environment.NewLine;
            this.metroTextBox2.Text += "Motors Responding...     All of them except above" + Environment.NewLine + Environment.NewLine;
        }

        private void metroBtnSearch_Click(object sender, EventArgs e)
        {
            try {

                int intFrom;
                if (!int.TryParse(metroTextBoxRangeFrom.Text, out intFrom))
                {
                    MessageBox.Show("Please enter a valid motor From search number","Error in motor from count",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                int intTo;
                if (!int.TryParse(metroTextBoxRangeTo.Text, out intTo))
                {
                    MessageBox.Show("Please enter a valid motor To search number", "Error in motor To count", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch { }
        }
    }
}
