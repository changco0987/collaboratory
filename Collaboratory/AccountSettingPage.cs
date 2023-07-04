using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Collaboratory.CustomControls;
using Collaboratory.Model;
using System.IO;
using System.Runtime.InteropServices;


namespace Collaboratory
{
    public partial class AccountSettingPage : Form
    {
        bool mousedown; // this is for the draggable panel behavior
        tb_userAccounts conn = new tb_userAccounts();
        Userdata user = new Userdata();


        //These are the properties used in picture and userDp
        private OpenFileDialog open;
        private string imgName;
        private string storagePath;
        private string webStoragePath = @"C:\xampp\htdocs\server\Image\";
        private string imgExtension;
        private string renamedImgName;


        public AccountSettingPage()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            storagePath = Application.UserAppDataPath + @"\Images\";
            if (!string.IsNullOrEmpty(UserLoginData.profilePicName))
            {
                //This will check if the image is existing in the local storage
                if (File.Exists(storagePath + UserLoginData.profilePicName))
                {
                    using (FileStream stream = new FileStream(storagePath + UserLoginData.profilePicName, FileMode.Open, FileAccess.Read))
                    {
                        userDP.Image = Image.FromStream(stream);
                        stream.Close();
                        stream.Dispose();
                    }
                }

            }

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
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizedBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        string oldImg;
        private void backBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            var backToUserPage = new UserProfilePage();

            backToUserPage.ShowDialog();
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

        private void userDP_Click(object sender, EventArgs e)
        {

        }

        //This is the method for deleting user account
        private void deleteaccBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete your account?\nThis can't be undone.", "Account Deletion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                user.id = UserLoginData.id;//This will assign the saved user login credential to user model
                conn.DeleteUser(user);

                Gmail gmail = new Gmail();
                string[] msg = gmail.accountDeleteNotif(UserLoginData.userId);
                gmail.sendMail(UserLoginData.email, msg[0], msg[1]);

                MessageBox.Show("Account Deleted!");

                //This will remove all saved credentials
                UserLoginData loginData = new UserLoginData();
                loginData.reset();

                this.Hide();
                var login = new LoginForm();
                login.ShowDialog();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Operation cancelled successfully");
            }
        }

        private void editprofileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var openEditPage = new SignupPage();
            openEditPage.ShowDialog();
            this.Close();
        }



        private void changepicBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //This will check and create a path for img storage
                if (!Directory.Exists(storagePath))
                {
                    Directory.CreateDirectory(storagePath);

                }

                //This is the parellel directory for img storage this also be used in the web app version
                if (!Directory.Exists(webStoragePath))
                {
                    Directory.CreateDirectory(webStoragePath);
                }


                //The using will use to dispose the code afterwards
                using (open = new OpenFileDialog())
                {

                    open.Filter = "Image Files(*.PNG;*.JPG;*.JPEG;)|*.PNG;*.JPG;*.JPEG;";//The file filter
                    if (open.ShowDialog() == DialogResult.OK)
                    {

                        userDP.Image = Image.FromFile("Asset/user.png");//To assign the picturebox a new image


                        oldImg = UserLoginData.profilePicName;//This will get to set as the old
                        imgName = open.FileName;//This is the dialog
                        imgExtension = Path.GetExtension(open.FileName);
                        renamedImgName = "Picture_id-" + UserLoginData.id + imgExtension;

                        /*
                         * it will check first if there is a previous user image and if yes
                         * it will delete it
                         */
                        if (!string.IsNullOrEmpty(oldImg))
                        {
                            System.Threading.Thread.Sleep(100);//This will use to at least give time  to close other process before using again
                            System.IO.File.Delete(storagePath + oldImg);//This will delete previous user image in the local copy
                            System.IO.File.Delete(webStoragePath + oldImg);//This will delete previous user image in the local copy

                        }


                        /*
                         * This will copy the selected file and paste it into the storagePath directory 
                         * and it will also rename the img file to shorten the original file name in order to 
                         * avoid coflict in database, and the 3rd parameter also means it will overwritten the 
                         * same name file in the storagePath directory if somehow exist
                         */

                        File.Copy(imgName, storagePath + renamedImgName, true);

                        UserLoginData.profilePicName = renamedImgName;//the dp name will assign to static model

                        using (FileStream stream = new FileStream(storagePath + UserLoginData.profilePicName, FileMode.Open, FileAccess.Read))
                        {
                            userDP.Image = Image.FromStream(stream);//This will refresh the picturebox to display the new selected image
                            stream.Close();
                        }
                        File.Copy(imgName, webStoragePath + renamedImgName, true);

                        user = user.statModelToModel(user);//This will transfer all static model data into model to update it in database
                        conn.UpdateUser(user);//This will save the user picture name into database

                        //GC.Collect();
                        MessageBox.Show("Profile Picture Changed!");
                    }
                    else
                    {
                        //This will prompt as backup incase an error has occur in changing user image
                        UserLoginData.profilePicName = oldImg;

                        user = user.statModelToModel(user);//This will transfer all static model data into model to update it in database
                        conn.UpdateUser(user);//This will save the user picture name into database
                        return;
                    }
                }



            }
            catch
            {
                MessageBox.Show("An error has occured!");
            }

        }




    }
}
