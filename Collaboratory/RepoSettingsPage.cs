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
using Collaboratory.CustomControls;
using System.Runtime.InteropServices;



namespace Collaboratory
{
    public partial class RepoSettingsPage : Form
    {
        //This is the model used to store to user input
        Repodata repository = new Repodata();

        //This is the model used to store to user input
        Userdata user = new Userdata();

        OvalPictureBox pictureBox = new OvalPictureBox();
        bool mousedown;// this is for the draggable panel behavior
        string storagePath = Application.UserAppDataPath + @"\\Images\\";

        public RepoSettingsPage()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            userList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userList.RowTemplate.MinimumHeight = 5;
            userList.RowTemplate.Resizable = DataGridViewTriState.True;
            userList.RowTemplate.Height = 20;
            repository.members = new List<int>();

            //this conditional statement is to check whether this page is being used to edit repo or to create repo
            if (SelectedRepoData.id!=0)
            {
                //To edit repo
                createBtn.Text = "Save";
                repository.statModelToModel(repository);//This will transfer all data from static model

                repoNameTb.Text = SelectedRepoData.repositoryName;
            }
            else 
            {
                //To create repo
                repository.members.Add(UserLoginData.id);//This will automatically add the owner in member list
            }

            this.DoubleBuffered = true;
            enableDoubleBuff(this);

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

        //This method is for the datagridview design
        public void defaultDatagridviewDesign()
        {

            userList.AllowUserToResizeRows = false;
            userList.AllowUserToResizeColumns = false;
            userList.Columns[0].Width = 1;
            userList.Columns[1].Width = 1;
        }



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

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            this.Close();//To close this windows and get back to the parent window
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
        private void createBtn_Click(object sender, EventArgs e)
        {
            /*
             * if the SelectedRepoData.id contains a number more than 0 
             * it means it uses this RepoSettingsPage as a settings to edit a existing repository
             * and not to create a new one
             */
            if (SelectedRepoData.id == 0)
            {
                if (!checkEmptyField() && getUserInput()) 
                {
                    createRepo();
                }

            }
            else if(!checkEmptyField() && getUserInput() && SelectedRepoData.id > 0)
            {
                updateRepo();
            }
            return;
        }

        void updateRepo()
        {
            tb_repositories conn = new tb_repositories();
            conn.UpdateRepo(repository);
            //This will also update the data from static model
            SelectedRepoData.repositoryName = repository.repositoryName;
            SelectedRepoData.members = repository.members.ToList();
            this.Hide();
            this.Refresh();
            this.Close();//To close this windows and get back to the parent window
        }

        void createRepo()
        {
            tb_repositories conn = new tb_repositories();
            conn.CreateRepo(repository);

            this.Hide();
            this.Refresh();
            this.Close();//To close this windows and get back to the parent window

        }

        //This will check if the userinput has symbol 
        bool checkSymbol()
        {
            Sanitize sanitize = new Sanitize();

            if (sanitize.sanitizeInput(repository.repositoryName))
            {
                return false;
            }
            return true;
        }

        //This will get all user input
        bool getUserInput()
        {
            repository.repositoryName = repoNameTb.Text;//The repository name
                                                        //This will sanitized the user input
            if (!checkSymbol())
            {
                MessageBox.Show("Please avoid using symbols in your repository name");
                return false;
            }

            repository.accountId = UserLoginData.id;//will save the user id as a owner
            return true;

        }

        //This method will check all imput field if there was an empty field
        bool checkEmptyField()
        {
            if (repoNameTb.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please enter repository name");
                return true;
            }

            return false;//This means that there is no empty field



        }

        //This is the search result
        void searchUser() 
        {
            //The Clear and Refresh will prevent for duplicating the previous fetch data when retype in search
            userList.Rows.Clear();
            userList.Refresh();


            List<Userdata> retrieveData = searchResult(searchTb.Text);


            Button button = new Button();
            int pictureBoxCount = 0;
            foreach (var data in retrieveData)
            {

                //This will avoid from adding the user information in the dataGridViewRow
                if (UserLoginData.id != data.id)
                {

                    pictureBox = new OvalPictureBox();
                    pictureBox.BackColor = ColorTranslator.FromHtml("#245382");
                    if (string.IsNullOrEmpty(data.profilePicName))
                    {
                        pictureBox.Image = Image.FromFile("Asset/user.png");//This is a default user dp if the user don't set it
                    }
                    else
                    {
                        pictureBox.Image = Image.FromFile(storagePath + data.profilePicName);
                    }



                    string accountId = data.id.ToString(); //This will be hidden in datagridview
                    string UserName = data.firstName + " " + data.lastName;
                    userList.Rows.Add(accountId, pictureBox.Image, UserName);
                    pictureBoxCount++;

                    //This iteration will check if the user is already added and it will show the checkIcon if so
                    if (repository.members.Contains(data.id))
                    {
                        userList.Rows[pictureBoxCount - 1].Cells[3].Value = Image.FromFile("Asset/checkIcon.png");
                    }
                    

                }
            }


            this.DoubleBuffered = true;
            enableDoubleBuff(userList);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchUser();
        }

        private void searchTb_KeyDown(object sender, KeyEventArgs e)
        {
            //if the user press enter this code block will trigger
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;

            }
        }

        ////This event is for the search box to automatically throw a result without the need to press ENTER key
        private void searchTb_KeyUp(object sender, KeyEventArgs e)
        {
            searchUser();
        }



        //This is the method for search
        public List<Userdata> searchResult(string searchKey) 
        {
            tb_userAccounts conn = new tb_userAccounts();

            List<Userdata> userdataList = new List<Userdata>();//This will be used to store all the search result

            List<DataRow> dbData = conn.ReadUser(user);

            foreach (var data in dbData) 
            {
                string wholeName = data[1].ToString()+" "+data[2].ToString();//This will combine the retrieve user data first and last name
                // This will compare the first name
                if (data[1].ToString().Contains(searchKey.ToLower()))
                {
                    //This will add to the result
                    var obj = new Userdata()
                    {
                        id = (int)data[0],
                        firstName = (string)data[1],
                        lastName = (string)data[2],
                        userId = (string)data[3],
                        password = (string)data[4],
                        birthday = data[5].ToString(),
                        gender = (string)data[6],
                        profilePicName = (string)data[7],
                        uak = (string)data[8],
                        email = (string)data[9]
                    };

                    userdataList.Add(obj);
                }//This will compare the last name 
                else if (data[2].ToString().Contains(searchKey.ToLower()))
                {
                    //This will add to the result
                    var obj = new Userdata()
                    {
                        id = (int)data[0],
                        firstName = (string)data[1],
                        lastName = (string)data[2],
                        userId = (string)data[3],
                        password = (string)data[4],
                        birthday = data[5].ToString(),
                        gender = (string)data[6],
                        profilePicName = (string)data[7],
                        uak = (string)data[8],
                        email = (string)data[9]
                    };

                    userdataList.Add(obj);
                }//This will compare the whole name
                else if (wholeName.Contains(searchKey.ToLower())) 
                {
                    //This will add to the result
                    var obj = new Userdata()
                    {
                        id = (int)data[0],
                        firstName = (string)data[1],
                        lastName = (string)data[2],
                        userId = (string)data[3],
                        password = (string)data[4],
                        birthday = data[5].ToString(),
                        gender = (string)data[6],
                        profilePicName = (string)data[7],
                        uak = (string)data[8],
                        email = (string)data[9]
                    };

                    userdataList.Add(obj);
                }

            }

            return userdataList;

        }


        string selectedRow = "";//this will be use as the rowIndex container
        private void userList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex.ToString();
            addMembers(Convert.ToInt32(selectedRow));

        }

        public void addMembers(int selectedRow) 
        {
            DataGridViewRow row = userList.Rows[selectedRow];//This will be the selected row in dataGridView


            //This will check if the member list is contain the selected row id and it will return a bool value
            bool selectedId = repository.members.Contains(Convert.ToInt32(row.Cells[0].Value));

            //This condition will check if the selected row is already added to the model as a member
            if (selectedId)
            {
                userList.Rows[selectedRow].Cells[3].Value = pictureBox.Image = Image.FromFile("Asset/add.png");
                repository.members.Remove(Convert.ToInt32(row.Cells[0].Value));
            }
            else
            {
                pictureBox.Image = Image.FromFile("Asset/checkIcon.png");
                userList.Rows[selectedRow].Cells[3].Value = pictureBox.Image;
                repository.members.Add(Convert.ToInt32(row.Cells[0].Value));
            }

            userList.Refresh();
            userList.Update();
            
        }


    }
}
