using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroSet_UI.Forms;

namespace FlexMold.Forms
{
    public partial class FrmSplashScreen : MetroSetForm
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            metroSetProgressBar1.Value += 1;
            if (metroSetProgressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                FrmHome objdashboard = new FrmHome();
                objdashboard.Show();

            }
        }
    }
}
