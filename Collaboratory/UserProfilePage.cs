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
using System.Runtime.InteropServices;


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
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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


        //To avoid the screen from stuttering to make the object movement smooth
        public static void enableDoubleBuff(System.Windows.Forms.Control cont)
        {
            System.Reflection.PropertyInfo DemoProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            DemoProp.SetValue(cont, true, null);
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


        private void MinimizedBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

   
            tb_repositories conn = new tb_repositories();

            List<DataRow> retrieveData = conn.ReadRepo("user", UserLoginData.id);

            foreach (var data in retrieveData)
            {
                int repoId = Convert.ToInt32(data[0]);
                string repoName = data[1].ToString();
                repoList.Rows.Add(repoId, repoName);
            }
     

            repoList.Refresh();
            repoList.Update();

        }

        int selectedRow;//this will be use as the rowIndex container
        private void repoList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;//This is the selected row in the datagridview/list of repository
            

            openRepoPage(selectedRow);//Then it will pass the id to this method


        }

        //This will trigger if the user click the repository
        async void openRepoPage(int selectedRow) 
        {
            DataGridViewRow row = repoList.Rows[selectedRow];

            int repoId = Convert.ToInt32(row.Cells[0].Value);//This is the cell for id

            tb_repositories repo = new tb_repositories();


            //Loading screen
            var splashScreen = new LoadingScreen();
            splashScreen.Show();

    

            await Task.Factory.StartNew(() =>
            {

                List<DataRow> retrieveData = repo.ReadRepo("repo", repoId);

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



                    List<DataRow> gcData = groupChats.ReadGC(groupdata);


                    //This will trigger only if the currently selected repo doesn't have groupchat yet created by the algorithm
                    if (gcData.Count() == 0)
                    {
                        groupChats.CreateGC(groupdata);//this will create a groupchat

                        gcData = groupChats.ReadGC(groupdata);//This will re-read the group chat after creation to ensure to get the updated data
                    }

                    //this will check if the selected repo has already groupchat
                    foreach (var gc in gcData)
                    {
                        //This will assign the groupchat id
                        currentGroupchat.id = Convert.ToInt32(gc[0]);
                    }

                }

                Task.Delay(5000);
            });
            splashScreen.Close();


            this.Hide();

            var openRepo = new RepositoryPage();
            openRepo.ShowDialog();
            this.Close();

        }


    }

}
