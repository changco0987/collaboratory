using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Collaboratory.CustomControls;

namespace Collaboratory
{
    public partial class chatBox : Form
    {
        public chatBox()
        {
            InitializeComponent();
            messageList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            messageList.GridColor = ColorTranslator.FromHtml("#E0EBED");
            //messageList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //messageList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //messageList.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //messageList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //messageList.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }


        private void chatBox_Load(object sender, EventArgs e)
        {

            messageList.Rows.Add("(Onah Marie)\nHello!kamustaHello!kamustaHello!kamustaHello!kamusa", "");
            messageList.Rows.Add("   ", "chat test 101 qwerty");
            messageList.Rows.Add("   ", "(Me)\nemail: admin@gmail.com\npassword:123456789");
            messageList.Rows.Add("   ", "(Me)\nemail: admin@gmail.com\npassword:123456789");
            messageList.Rows.Add("hello!!!! test chat\n1010101", "");
            messageList.Rows.Add("gumagana na kaya ito,\n final testing na thiss", "");
            messageList.Rows.Add("GG kids na!!", "");
            messageList.Rows.Add("   ", "openn");
            messageList.Rows.Add("test code 123", "");
            messageList.Rows.Add("   ", "chat mo ulo mo\nchat box credibility test");
            messageList.Rows.Add("test code 123", "");
            messageList.Rows.Add("   ", "chat mo ulo mo\nchat box credibility test");
            messageList.Rows.Add("test code 123", "");
            messageList.Rows.Add("   ", "chat mo ulo mo\nchat box credibility test");
            messageList.Rows.Add("   ", "email: admin@gmail.com\npassword:123456789");
            messageList.Rows.Add("hello!!!! test chat\n1010101", "");
            messageList.Rows.Add("gumagana na kaya ito,\n final testing na thiss", "");
            messageList.Rows.Add("   ", "email: admin@gmail.comdasdsdasdasdasdasd asdadasdadadasdasdasdasdasdad adadadadadadadadadadada dadadapassword:123456789");
            messageList.Rows.Add("hello!!!! test chat\n1010101", "");
            messageList.Rows.Add("gumagana na kaya ito,\n final testing na thiss", "");
            messageList.Rows.Add("   ", "email: admin@gmail.com\npassword:123456789");
            messageList.Rows.Add("hello!!!! test chat\n1010101", "");
            messageList.Rows.Add("asdfasdfasdfasdfasdfas itoffsdfdfsdfsdfsd,\n final testing na thiss", "");
            //These are the default style for datagridview.updateList
            foreach (DataGridViewRow row in messageList.Rows)
            {
                if (row.Cells[0].Value.ToString().Trim().Count() >0)
                {

                    row.Cells[0].Value = row.Cells[0].Value.ToString().Trim();
                    row.Cells[0].Style.Font = new Font("Bahnschrift", 11, FontStyle.Regular);
                    row.Cells[0].Style.BackColor = ColorTranslator.FromHtml("#245382");
                }

                if (row.Cells[1].Value.ToString().Trim().Count() >0) 
                {
                    row.Cells[1].Value = row.Cells[1].Value.ToString().Trim();
                    row.Cells[1].Style.Font = new Font("Bahnschrift", 11, FontStyle.Regular);
                    row.Cells[1].Style.ForeColor = Color.Black;
                    row.Cells[1].Style.BackColor = ColorTranslator.FromHtml("#90EE90");
                }
                //post title, poser name, date posted

                //edit, note, download button part


            }
        }

        private void messageList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex == -1)
            {
                var dgv = (DataGridView)sender;
                var r = e.CellBounds;
                var w = 0;
                if (e.ColumnIndex > -1)
                {
                    w = dgv.Columns[e.ColumnIndex].DividerWidth;
                    r.Width = r.Width - w;
                }
                e.Graphics.SetClip(r);
                e.Paint(r, DataGridViewPaintParts.All);
                e.Graphics.SetClip(e.CellBounds);
                if (w > 0)
                {
                    r = new Rectangle(r.Right - 1, r.Top, w + 1, r.Height);
                    using (var brush = new SolidBrush(dgv.GridColor))
                        e.Graphics.FillRectangle(brush, r);
                }
                e.Handled = true;
            }
        }

        //This will be disable the capability to select in datagridview
        private void messageList_SelectionChanged(object sender, EventArgs e)
        {
            messageList.ClearSelection();
        }
    }
}
