﻿using System;
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



namespace Collaboratory
{
    public partial class UserProfilePage : Form, IDisposable
    {

        //This is the model used to store to user input
        public Userdata user = new Userdata();


        bool mousedown; // this is for the draggable panel behavior
        string storagePath = Application.UserAppDataPath + @"\\Images\\";
        public UserProfilePage()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            enableDoubleBuff(this);
            //This will be the default dp if the user profile doesn't have
            if (!string.IsNullOrEmpty(UserLoginData.profilePicName))
            {
                //This will check if the image is existing in the local storage
                if (File.Exists(storagePath+UserLoginData.profilePicName)) 
                {
                    using (FileStream stream = new FileStream(storagePath + UserLoginData.profilePicName, FileMode.Open, FileAccess.Read))
                    {
                        userDP.Image = Image.FromStream(stream);
                        stream.Close();
                    }
                }
            }


            getUserRepo();
            this.repoList.GridColor = ColorTranslator.FromHtml("#171433");//To change the grid of repoList element color




        }

        /*
         * The code below is the form UI functions
         */

        //To avoid the windows form from flickering
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }

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

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         *panel1_MouseMove(), panel1_MouseDown(), and panel1_MouseUp()
         *these are the events that makes the panel draggable
         */
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



        /*
        * The code below is the app functionality like data, accounts algo etc
        */


        public void UserProfilePage_Load(object sender, EventArgs e)
        {
            repoList.Refresh();
            repoList.Update();
            usernameLb.Text = UserLoginData.firstName + " " + UserLoginData.lastName;
            useridLb.Text = UserLoginData.userId;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Dispose();

            //This will reset all data that has been saved in static variables
            UserLoginData resetData = new UserLoginData();
            resetData.reset();

            this.Hide();
            var loginPage = new LoginForm();
            loginPage.ShowDialog();
            this.Close();
        }


        public void Dispose()
        {
            Dispose(true);
            GC.Collect();
            GC.SuppressFinalize(this);
        }

        private void accsettingsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var openAccSettPage = new AccountSettingPage();
            openAccSettPage.ShowDialog();
            this.Close();
        }

        private void createRepoBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            var openCreateRepo = new RepoSettingsPage();
            openCreateRepo.ShowDialog();
            getUserRepo();
            repoList.Refresh();
            repoList.Update();
            //this.Close();
        }

        //This method will retrieved all repositories that associate with the user
        void getUserRepo()
        {

            repoList.Rows.Clear();
            repoList.Refresh();

            tb_repositories conn = new tb_repositories();

            List<DataRow> retrieveData = conn.ReadRepo("user",UserLoginData.id);

            foreach (var data in retrieveData)
            {
                int repoId = Convert.ToInt32(data[0]);
                string repoName = data[1].ToString();
                repoList.Rows.Add(repoId, repoName);
            }


        }

        int selectedRow;//this will be use as the rowIndex container
        private void repoList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;//This is the selected row in the datagridview/list of repository

            openRepoPage(selectedRow);//Then it will pass the id to this method

            this.Hide();

            var openRepo = new RepositoryPage();
            openRepo.ShowDialog();
            this.Close();
        }

        void openRepoPage(int selectedRow) 
        {
            DataGridViewRow row = repoList.Rows[selectedRow];

            int repoId = Convert.ToInt32(row.Cells[0].Value);//This is the cell for id

            tb_repositories repo = new tb_repositories();


            List<DataRow> retrieveData = repo.ReadRepo("repo",repoId);

            //data{id, repositoryName, members[], accountId}
            foreach (var data in retrieveData)
            {
                SelectedRepoData.id = Convert.ToInt32(data[0]);

                SelectedRepoData.repositoryName = data[1].ToString();

                IEnumerable<int> memberList = (IEnumerable<int>)data[2];//this is were the member located in index data[2]

                //This will transfer the all member from selected repository into the static model
                SelectedRepoData.members = new List<int>();
                foreach (int member in memberList) 
                {
                    SelectedRepoData.members.Add(member);
                }

                SelectedRepoData.accountId = Convert.ToInt32(data[3]);

                //To create a groupchat
                tb_groupChats groupChats = new tb_groupChats();
                Groupchatdata groupdata = new Groupchatdata();

                groupdata.repositoryId = SelectedRepoData.id;

                //this will check first if the selected repo has already groupchat

                List<DataRow> gcData = groupChats.ReadGC(groupdata);
                foreach (var gc in gcData)
                {
                    currentGroupchat.id = Convert.ToInt32(gc[0]);
                }

                if (gcData.Count() == 0)
                {
                    groupChats.CreateGC(groupdata);//this will create a groupchat
                }

            }
        }

    }

}