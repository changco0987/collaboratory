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
    public partial class NotePage : Form
    {
        public NotePage()
        {
            InitializeComponent();
            noteTb.Text = SelectedUpdateData.note;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
