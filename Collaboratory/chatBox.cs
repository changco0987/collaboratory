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
using Collaboratory.Model;

namespace Collaboratory
{
    public partial class chatBox : Form
    {

        //Global variables
        bool mousedown; // this is for the draggable panel behavior
        int msgCount;
        tb_userAccounts userConn = new tb_userAccounts();
        tb_messages msgConn = new tb_messages();
        Messagedata msgData = new Messagedata();
        Userdata user = new Userdata();
        string storagePath = Application.UserAppDataPath + @"\\Images\\";

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

            dataContainer.Columns.Add("");//This is just to have our container a column
            retrieveMembers();//This is all the members picture, this will appear at the left side of the screen

            msgData.groupchatId = currentGroupchat.id;//To get the current GC Id

            //This will get all msg from database into datagridview(messageList)
            getAllMessages();



            timer1.Start();


            //To automatically scroll the message box into the bottom
            messageList.FirstDisplayedScrollingRowIndex = messageList.RowCount - 1;
            this.DoubleBuffered = true;
            enableDoubleBuff(this);

        }

        public void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                int mousex = MousePosition.X - 400;
                int mousey = MousePosition.Y - 20;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        public void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        public void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        void checkNewMsg() 
        {

            List<DataRow> messages = msgConn.ReadMessage(msgData);

            if (messages.Count != dataContainer.Rows.Count)
            {
                dataContainer.Rows.Clear();
                foreach (var dataMsg in messages)
                {
                    dataContainer.Rows.Add(dataMsg[1]);
                }

            }
        }

        void getAllMessages() 
        {

            string senderName = "";
            //chat max letter is 38

            messageList.Rows.Clear();
            messageList.Refresh();
            messageList.Update();
            List<DataRow> messages = msgConn.ReadMessage(msgData);

            //This will get all the msg from the current groupchat
            foreach (var data in messages)
            {
                string msg = data[1].ToString();
                user.id = Convert.ToInt32(data[3]);
                List<DataRow> dbData = userConn.ReadUser(user);

                //This will get the information of the sender message
                foreach (var userinfo in dbData)
                {
                    if (UserLoginData.id == Convert.ToInt32(userinfo[0]))
                    {
                        senderName = "(Me)\n";
                        messageList.Rows.Add("", senderName + msg);
                    }
                    else
                    {
                        senderName = "(" + userinfo[1].ToString() + userinfo[2].ToString() + ")\n";
                        messageList.Rows.Add(senderName + msg,"");
                    }
                }
            }
            this.DoubleBuffered = true;
            enableDoubleBuff(messageList);
        }
        private void chatBox_Load(object sender, EventArgs e)
        {

            //These are the default style for datagridview.messageList
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

                messageList.FirstDisplayedScrollingRowIndex = messageList.RowCount - 1;
                this.DoubleBuffered = true;
                enableDoubleBuff(messageList);
            }
        }

        //To avoid the screen from stuttering to make the object movement smooth
        public static void enableDoubleBuff(System.Windows.Forms.Control cont)
        {
            System.Reflection.PropertyInfo DemoProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            DemoProp.SetValue(cont, true, null);
        }
        void retrieveMembers() 
        {

            PictureBox picture = new PictureBox();
            foreach (var member in SelectedRepoData.members) 
            {
                user.id = member;
                List<DataRow>dbData = userConn.ReadUser(user);

                //This will extract the image name from user data
                foreach (var data in dbData) 
                {
                    if (string.IsNullOrEmpty(data[7].ToString()))
                    {
                        picture.Image = Image.FromFile("Asset/user.png");//This is a default user dp if the user don't set it
                    }
                    else 
                    {
                        picture.Image = Image.FromFile(storagePath + data[7].ToString());
                    }
                }

                memberList.Rows.Add(user.id,picture.Image);
            }

        }

        private void messageList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            //if (e.RowIndex == -1)
            //{
            //    var dgv = (DataGridView)sender;
            //    var r = e.CellBounds;
            //    var w = 0;
            //    if (e.ColumnIndex > -1)
            //    {
            //        w = dgv.Columns[e.ColumnIndex].DividerWidth;
            //        r.Width = r.Width - w;
            //    }
            //    e.Graphics.SetClip(r);
            //    e.Paint(r, DataGridViewPaintParts.All);
            //    e.Graphics.SetClip(e.CellBounds);
            //    if (w > 0)
            //    {
            //        r = new Rectangle(r.Right - 1, r.Top, w + 1, r.Height);
            //        using (var brush = new SolidBrush(dgv.GridColor))
            //            e.Graphics.FillRectangle(brush, r);
            //    }
            //    e.Handled = true;
            //}
        }

        //This will be disable the capability to select in datagridview
        private void messageList_SelectionChanged(object sender, EventArgs e)
        {
            messageList.ClearSelection();
        }

        private void memberList_SelectionChanged(object sender, EventArgs e)
        {
            memberList.ClearSelection();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (messageTb.Text.Count() >0) 
            {
                msgData.message = messageTb.Text;
                msgData.accountId = UserLoginData.id;

                msgConn.CreateMessage(msgData);
                getAllMessages();
                messageTb.Text = "";

                chatBox_Load(sender,null);
            }

        }

        DataTable dataContainer = new DataTable();
        BackgroundWorker bw;
        private void timer1_Tick(object sender, EventArgs e)
        {
            bw = new BackgroundWorker();
            bw.DoWork += (obj, ea) => TaskAsync(1);
            bw.RunWorkerAsync();

            if (dataContainer.Rows.Count != messageList.Rows.Count)
            {
                getAllMessages();
                chatBox_Load(sender, null);
            }





        }

        private async void TaskAsync(int times) 
        {
            checkNewMsg();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();

            this.Close();
        }

        private void chatBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendBtn_Click(sender, null);
            }
        }


    }
}
