using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Collaboratory.CustomControls;
using Collaboratory.Model;
using System.Security.Cryptography;
using LiveCharts;
using LiveCharts.Wpf;

namespace Collaboratory
{
    public partial class RepositoryPage : Form
    {


        //This is the model used to store to user input
        Userdata user = new Userdata();

        List<MemberContribution> memberContri = new List<MemberContribution>();
        bool mousedown; // this is for the draggable panel behavior
        string storagePath = Application.UserAppDataPath + @"\\Images\\";
        public RepositoryPage()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            enableDoubleBuff(this);
            //This is the user informatio to be shown in the panel
            usernameLb.Text = UserLoginData.firstName + " " + UserLoginData.lastName;
            useridLb.Text = UserLoginData.userId;
            reponameLb.Text = SelectedRepoData.repositoryName;

            //This will be the default dp if the user profile doesn't have
            if (!string.IsNullOrEmpty(UserLoginData.profilePicName))
            {
                //This will check if the image is existing in the local storage
                if (File.Exists(storagePath + UserLoginData.profilePicName))
                {
                    using (FileStream stream = new FileStream(storagePath + UserLoginData.profilePicName, FileMode.Open, FileAccess.Read))
                    {
                        userDP.Image = Image.FromStream(stream);
                        stream.Close();
                    }
                }
            }

            /*
             * This is to check if who ever visit to the current repo is the owner/creator
             * else, it will disable the edit repo button
             */
            if (SelectedRepoData.accountId != UserLoginData.id) 
            {
                editRepoBtn.Enabled = false;
                editRepoBtn.BackColor = Color.LightGray;
            }


            threadBtn_Click(threadBtn,null);//This will click the thread button as a default tab page
            retrieveUpdates();
        }


        /*
         * The code below is the form UI functions
         */
        //To avoid the screen from stuttering to make the object movement smooth
        public static void enableDoubleBuff(System.Windows.Forms.Control cont)
        {
            System.Reflection.PropertyInfo DemoProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            DemoProp.SetValue(cont, true, null);
        }


        private void MinimizedBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizeBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {

                this.WindowState = FormWindowState.Normal;
                this.DoubleBuffered = true;
                enableDoubleBuff(this);
            }
            else
            {

                this.WindowState = FormWindowState.Maximized;
                this.DoubleBuffered = true;
                enableDoubleBuff(this);
            }

        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.ActiveControl.Dispose();
            this.Close();
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



        private void uploadBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var openUpload = new UploadPage();
            openUpload.ShowDialog();

            reloadPostPanel(sender);
        }


        /*
         * The code below is the app functionality like data, accounts algo etc
         */

        void retrieveUpdates()
        {
            //The Clear and Refresh will prevent for duplicating the previous fetch data when retype in search
            updateList.Rows.Clear();
            updateList.Refresh();

            Updatedata update = new Updatedata();
            update.repositoryId = SelectedRepoData.id;//This will assign the repository id into update model
            tb_updates conn = new tb_updates();
            tb_userAccounts connUser = new tb_userAccounts();

            List<DataRow> dbData = conn.ReadPost(update);

            foreach (var data in dbData)
            {

                PictureBox editBtn = new PictureBox();
                PictureBox noteBtn = new PictureBox();
                PictureBox downloadBtn = new PictureBox();





                user.id = Convert.ToInt32(data[5]);//This is the id of the uploader
                List<DataRow> userData = connUser.ReadUser(user);//This will retrieve the uploader info using their id
                foreach (var userInfo in userData)
                {
                    string uploaderName = userInfo[1].ToString() + " " + userInfo[2].ToString();

                    //This will trigger if the viewer is not the creator of the post
                    if (UserLoginData.id != Convert.ToInt32(userInfo[0]))
                    {
                        editBtn.Image = Image.FromFile("Asset/icons8-edit2-30.png");//bnw icon

                        //This will check if there is a file uploaded in the current post
                        if (string.IsNullOrEmpty(data[2].ToString()))
                        {
                            noteBtn.Image = Image.FromFile("Asset/icons8-note-30.png");//default icon
                            downloadBtn.Image = Image.FromFile("Asset/icons8-download2-resume-30.png");//bnw icon


                            //data position in array data{update_id, title, spaceCol, uploader_name, spaceCol2, datetime, editBtn, noteBtn, downloadBtn}
                            updateList.Rows.Add(data[0], data[1], " ", uploaderName, "", data[4], editBtn.Image, noteBtn.Image, downloadBtn.Image);
                        }
                        else 
                        {
                            //data position in array data{update_id, title, spaceCol, uploader_name, spaceCol2, datetime, editBtn}
                            updateList.Rows.Add(data[0], data[1], " ", uploaderName, "", data[4], editBtn.Image);
                        }

                    }
                    else 
                    {
                        //This will check if there is a file uploaded in the current post
                        if (string.IsNullOrEmpty(data[2].ToString()))
                        {
                            editBtn.Image = Image.FromFile("Asset/icons8-edit-30.png");//default icon
                            noteBtn.Image = Image.FromFile("Asset/icons8-note-30.png");//default icon
                            downloadBtn.Image = Image.FromFile("Asset/icons8-download2-resume-30.png");//bnw icon


                            //data position in array data{update_id, title, spaceCol, uploader_name, spaceCol2, datetime, editBtn, noteBtn, downloadBtn}
                            updateList.Rows.Add(data[0], data[1], " ", uploaderName, "", data[4], editBtn.Image, noteBtn.Image, downloadBtn.Image);
                        }
                        else 
                        {

                            //data position in array data{update_id, title, spaceCol, uploader_name, spaceCol2, datetime}
                            updateList.Rows.Add(data[0], data[1], " ", uploaderName, "", data[4]);
                        }
                    }
                }




            }

            getContribution();
            updateList.Refresh();
            updateList.Update();

        }

        void getContribution() 
        {
            int indexCount = 0;//This will be used in the loop as index count

            memberContri = new List<MemberContribution>();


            Updatedata update = new Updatedata();
            tb_updates conn = new tb_updates();
            tb_userAccounts connUser = new tb_userAccounts();

            //This will get the name of the user/contributor
            foreach (var getUserInfo in SelectedRepoData.members) 
            {
                user.id = Convert.ToInt32(getUserInfo);//This is the id of the uploader
                List<DataRow> userData = connUser.ReadUser(user);//This will retrieve the uploader info using their id

                foreach (var user in userData) 
                {
                    string fullname = user[1] + " " + user[2];
                    update.repositoryId = SelectedRepoData.id;//This is the id of currently selected repo
                    update.accountId = Convert.ToInt32(user[0]);//This is the posser id

                    List<DataRow> dbData = conn.ReadPost(update);

                    
                    memberContri.Add(new MemberContribution() 
                    {
                        id= Convert.ToInt32(user[0]),//To insert to user id
                        name =fullname,//To insert the name of the user
                        contriCount = dbData.Count//This will get the post count of the user
                    });
                }



                indexCount++;
            }

        }






        private void RepositoryPage_Load(object sender, EventArgs e)
        {

            //This is the empty message in the datagridview (if there is no post in the thread)
            if (updateList.Rows.Count == 0)
            {
                emptyImg.Visible = true;
                emptyLb.Visible = true;
            }
            else
            {
                emptyImg.Visible = false;
                emptyLb.Visible = false;
            }

            //These are the default style for datagridview.updateList
            foreach (DataGridViewRow row in updateList.Rows)
            {

                //post title, poser name, date posted
                row.Cells[1].Style.Font = new Font("Verdana", 13, FontStyle.Bold);
                row.Cells[3].Style.Font = new Font("Verdana", 11, FontStyle.Regular);
                row.Cells[5].Style.Font = new Font("Verdana", 10, FontStyle.Regular);

                //edit, note, download button part
                row.Cells[6].Style.BackColor = ColorTranslator.FromHtml("#429e9d");
                row.Cells[7].Style.BackColor = ColorTranslator.FromHtml("#429e9d");
                row.Cells[8].Style.BackColor = ColorTranslator.FromHtml("#429e9d");

            }
            this.DoubleBuffered = true;
            enableDoubleBuff(updateList);

            pieChart1.LegendLocation = LegendLocation.Bottom;



        }

        private void chatBtn_Click(object sender, EventArgs e)
        {
            var openChatBox = new chatBox();
            openChatBox.ShowDialog();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            SelectedRepoData selectedRepo = new SelectedRepoData();
            selectedRepo.reset();//This will reset and remove all data from previous selected repo

            this.Hide();
            var backToUser = new UserProfilePage();
            backToUser.ShowDialog();
            this.Close();
        }

        void reloadPostPanel(object sender)
        {
            retrieveUpdates();

            RepositoryPage_Load(sender, null);//This will call the load event
        }

        //this event will trigger when the user hit the editBtn, noteBtn, and downloadBtn
        private void updateList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var updateId  = updateList.Rows[e.RowIndex].Cells[0].Value;//This will get the row/update ID
            var title  = updateList.Rows[e.RowIndex].Cells[1].Value;//This will get the row/update title
            int clickedCell = e.ColumnIndex;//This will get the button index


            SelectedUpdateData.id = Convert.ToInt32(updateId);
            SelectedUpdateData.title = title.ToString();

            Updatedata updatedata = new Updatedata();
            updatedata.id = SelectedUpdateData.id;
            getPostData(updatedata);//To get all post/update data and stored it into the static model

            /*
             * clickedCell;
             * 6 = editBtn
             * 7 = noteBtn
             * 8 = downloadBtn
             */
            if (clickedCell == 6)
            {
                //edit


                /*
                 * This will check if clicker of this post/update is the one who post it
                 * if not the clicker cannot edit this post
                 */
                if (SelectedUpdateData.accountId == UserLoginData.id) 
                {
                    var openEditPost = new EditUploadPage();
                    openEditPost.ShowDialog();

                    reloadPostPanel(sender);
                }

            }
            else if (clickedCell == 7) 
            {
                //note

                var openNote = new NotePage();
                openNote.ShowDialog();

                reloadPostPanel(sender);
            }
            else if (clickedCell == 8) 
            {
                //download
                if (!string.IsNullOrEmpty(SelectedUpdateData.fileName)) 
                {
                    string fileOrigin = Application.UserAppDataPath + @"\repoFile_id" + SelectedRepoData.id + "\\";
                    string downloadLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\";

                    string fileName = SelectedUpdateData.fileName;//This is were the final file name inputted
                    string tempFileName = fileName;//This is just a container for renaming and checking if file exist
                    string fileExtension = Path.GetExtension(fileName);
                    int fileCount = 1;

                    while (File.Exists(downloadLocation + tempFileName))
                    {
                        /*
                        * This will reassemble the file name and insert the (n) count, 
                        * depends on the file count in the same file directory
                        */
                        tempFileName = fileName.Substring(0, fileName.IndexOf('.')) + "(" + fileCount + ")" + fileExtension;
                        fileCount++;
                    }
                    fileName = tempFileName;//This is to finalize the fileName
                    File.Copy(fileOrigin + SelectedUpdateData.fileName, downloadLocation + fileName, false);

                    MessageBox.Show("Download Successfully\nDownload Location on\n" + downloadLocation);
                    return;
                }
               
            }
        }


        //This method will get selected post info
        void getPostData(Updatedata updatedata)
        {
            tb_updates conn = new tb_updates();
            List<DataRow> dbData = conn.ReadPost(updatedata);

            foreach (var data in dbData) 
            {
                SelectedUpdateData.fileName = data[2].ToString();
                SelectedUpdateData.note = data[3].ToString();
                SelectedUpdateData.postDatetime = data[4].ToString();
                SelectedUpdateData.accountId = Convert.ToInt32(data[5].ToString());
                SelectedUpdateData.repositoryId = Convert.ToInt32(data[6].ToString());

            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            var openAccSettings = new AccountSettingPage();
            openAccSettings.ShowDialog();
            this.Close();
        }

        private void editRepoBtn_Click(object sender, EventArgs e)
        {
            var openRepoSettings = new RepoSettingsPage();
            openRepoSettings.ShowDialog();
            reponameLb.Text = SelectedRepoData.repositoryName;
        }

        private void threadBtn_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedIndex = 0;

            threadBtn.Top = 10;
            contributionBtn.Top = 17;

            threadBtn.Size = new Size(168, 44);
            contributionBtn.Size = new Size(168, 37);
        }

        Func<ChartPoint, string> labelPoint = chartpoint => String.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);
        private void contributionBtn_Click(object sender, EventArgs e)
        {
            SeriesCollection series = new SeriesCollection();
            foreach (var row in memberContri) 
            {
                series.Add(new PieSeries() { Title = row.name, Values = new ChartValues<int> { row.contriCount}, DataLabels = true, LabelPoint= labelPoint });
            }
            pieChart1.Series = series;


            tabControl1.SelectedIndex = 1;

            contributionBtn.Top = 10;
            threadBtn.Top = 17;

            contributionBtn.Size = new Size(168, 44);
            threadBtn.Size = new Size(168, 37);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

    }
}