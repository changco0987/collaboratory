using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Collaboratory.Model;

namespace Collaboratory
{
    public partial class AppSettingsPage : Form
    {
        public AppSettingsPage()
        {
            InitializeComponent();
        }

        private void AppSettingsPage_Load(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (dbPasswordInput.Text.Trim() != string.Empty)
            {
                appSettings settings = new appSettings();
                settings.setPassword(dbPasswordInput.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("The db password must not be empty!");
            }
        }


    }
}
