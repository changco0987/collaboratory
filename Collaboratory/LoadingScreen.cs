using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collaboratory
{
    public partial class LoadingScreen : Form
    {
        private int timerTime = 0;
        public LoadingScreen()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerTime++;
            if (timerTime==3) 
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
