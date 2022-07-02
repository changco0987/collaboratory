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
using System.Media;
using System.Runtime.InteropServices;

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

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


            dataContainer.Columns.Add("");//This is just to have our container a column
            retrieveMembers();//This is all the members picture, this will appear at the left side of the screen

            msgData.groupchatId = currentGroupchat.id;//To get the current GC Id



            messageList.VirtualMode = true;


            timer1.Start();



            this.DoubleBuffered = true;
            enableDoubleBuff(this);

        }


        //To avoid the screen from stuttering to make the object movement smooth
        public static void enableDoubleBuff(System.Windows.Forms.Control cont)
        {
            System.Reflection.PropertyInfo DemoProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            DemoProp.SetValue(cont, true, null);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

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

        string msgFormatter(string message) 
        {
            double letterCount = message.Length / 32;
            if (message.Length>32)
            {
                if (message.Length % 32 > 0)
                {
                    letterCount++;
                }

                for (int count = 1; count <= letterCount; count++)
                {
                    if ((message.Length - (32 * count)) >= 32)
                    {
                        message = message.Insert(32 * count, "\n");
                    }
                    else
                    {
                        message = message.Insert((message.Length - message.Length % 32), "\n");
                    }
                }

                //This last insert will make sure that the message box doesn't overlap to chatbox height
                if (message.Length>=100)
                {
                    message = message.Insert(message.Length, "\n");
                }
            }
            

            return message;
        }




        //This method will get/retrieve all messages from database 
        void getAllMessages() 
        {

            string senderName = "";
            //chat max letter is 38

            //DataTable dt = new DataTable();
            //dt.Columns.Add("chatmateCol");
            //dt.Columns.Add("myChatCol");

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
                        messageList.Rows.Add("", senderName + msgFormatter(msg));
                    }
                    else
                    {
                        //(Firstname + Lastname)
                        senderName = "(" + userinfo[1].ToString() + " " +userinfo[2].ToString() + ")\n";
                        messageList.Rows.Add(senderName + msgFormatter(msg), "");
                    }
                }
            }

            //To automatically scroll the message box into the bottom
            //This will check first if there is chat in the chat box and if none then the scroll function will not be triggered
            if (messageList.Rows.Count > 0)
            {


                messageList.FirstDisplayedScrollingRowIndex = messageList.RowCount - 1;
            }
            //messageList.DataSource = dt;
            this.DoubleBuffered = true;
            enableDoubleBuff(messageList);
        }
        private void chatBox_Load(object sender, EventArgs e)
        {
            messageList.VirtualMode = false;
            messageList.AutoGenerateColumns = false;
            //This will get all msg from database into datagridview(messageList)
            getAllMessages();
            //These are the default style for datagridview.messageList


            this.DoubleBuffered = true;
            enableDoubleBuff(messageList);
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
                        using (FileStream stream = new FileStream(storagePath + data[7].ToString(), FileMode.Open,FileAccess.Read))
                        {
                            picture.Image = Image.FromStream(stream);
                            stream.Close();
                        }
                    }
                }

                memberList.Rows.Add(user.id,picture.Image);
            }

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

                //this will check if the data that required to send a message is meet and already stored
                if (msgData.groupchatId == 0 && currentGroupchat.id != 0)
                {
                    msgData.groupchatId = currentGroupchat.id;
                }
                else if(msgData.groupchatId == 0 && currentGroupchat.id == 0)
                {
                    MessageBox.Show("Message sending failed!");
                    return;
                }

                msgConn.CreateMessage(msgData);
                getAllMessages();
                messageTb.Text = "";

                //chatBox_Load(sender,null);
            }

        }


        //This will be used in the backgroundWorker function
        void checkNewMsg()
        {
            try
            {
                List<DataRow> messages = msgConn.ReadMessage(msgData);

                if (messages.Count != dataContainer.Rows.Count)
                {
                    dataContainer.Rows.Clear();
                    //timer1.Stop();
       
                    foreach (var dataMsg in messages)
                    {
                        dataContainer.Rows.Add(dataMsg[1]);
                    }              
                }
                messages.Clear();
            }
            catch
            {
                //This will occur incase the conn.open() fails 
                msgConn.EmergencyCleaner();
                List<DataRow> messages = msgConn.ReadMessage(msgData);
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
                timer1.Stop();

                SoundPlayer sound = new SoundPlayer(@"Asset\Sound\chatSound.wav");
                sound.Play();

                getAllMessages();
                //chatBox_Load(sender, null);

                timer1.Start();
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

        private void messageList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void messageList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void messageList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in messageList.Rows)
            {
                if (row.Cells[0].Value.ToString().Trim().Count() > 0)
                {

                    //row.Cells[0].Value = row.Cells[0].Value.ToString().Trim();
                    row.Cells[0].Style.Font = new Font("Bahnschrift", 11, FontStyle.Regular);
                    row.Cells[0].Style.BackColor = ColorTranslator.FromHtml("#245382");
                }

                if (row.Cells[1].Value.ToString().Trim().Count() > 0)
                {
                    //row.Cells[1].Value = row.Cells[1].Value.ToString().Trim();
                    row.Cells[1].Style.Font = new Font("Bahnschrift", 11, FontStyle.Regular);
                    row.Cells[1].Style.ForeColor = Color.Black;
                    row.Cells[1].Style.BackColor = ColorTranslator.FromHtml("#90EE90");
                }

                //post title, poser name, date posted

                //edit, note, download button part
            }


            this.DoubleBuffered = true;
            enableDoubleBuff(messageList);
        }
    }
}
