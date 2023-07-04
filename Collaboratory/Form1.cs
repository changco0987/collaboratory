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
using Collaboratory.Model;
using Collaboratory.CustomControls;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace Collaboratory
{
    public partial class LoginForm : Form
    {


        //This is the model used to store to user input
        Userdata user = new Userdata();

        bool mousedown; // this is for the draggable panel behavior

        public LoginForm()
        {
            InitializeComponent();
            UserLoginData logindata = new UserLoginData();
            logindata.reset();//to clear the saved userdata
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.DoubleBuffered = true;
            enableDoubleBuff(this);

            checkPoint();
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


        //To avoid the screen from stuttering to make the object movement smooth
        public static void enableDoubleBuff(System.Windows.Forms.Control cont)
        {
            System.Reflection.PropertyInfo DemoProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            DemoProp.SetValue(cont, true, null);
        }

        /*
         * The code below is the form UI functions
         */
        private void MinimizedBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        /*
         * The code below is the app functionality like data, accounts algo etc
         */

        private void signupBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            var signupPage = new SignupPage();

            signupPage.ShowDialog();
            this.Close();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            var openAuthPage = new authenticationPage();
            openAuthPage.ShowDialog();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            checkLoginData();

            /*
             * This code will get trigger if the user fail to login
             * This code will remove all white-spaces in the input field
             */
            useridTb.Text = useridTb.Text.Trim();
            passwordTb.Text = passwordTb.Text.Trim();

        }



        void checkLoginData()
        {
            if (checkEmptyField())
            {
                getUserInput();
                checkAccount();
            }
        }

        //This method will retrieve all user info and save it to the static model
        void saveLoginData(int id)
        {
            tb_userAccounts conn = new tb_userAccounts();
            user.id = id;
            List<DataRow> dbData = conn.ReadUser(user);

            //This will save all user login data from database to static variables
            foreach (var data in dbData)
            {
                UserLoginData.id = Convert.ToInt32(data[0]);
                UserLoginData.firstName = (string)data[1];
                UserLoginData.lastName = (string)data[2];
                UserLoginData.userId = (string)data[3];
                UserLoginData.password = (string)data[4];
                UserLoginData.birthday = data[5].ToString();
                UserLoginData.gender = (string)data[6];
                UserLoginData.profilePicName = (string)data[7];
                UserLoginData.uak = (string)data[8];
                UserLoginData.email = (string)data[9];
            }
        }


        void checkAccount()
        {
            try
            {
                tb_userAccounts conn = new tb_userAccounts();
                List<DataRow> dbData = conn.ReadUser(user);//This will transfer the ReadUser() returned value into dbData

                foreach (var data in dbData)
                {
                    /*
                     * The data index 3 is the location of userid and data index 4 is the location of password
                     * This will check if the userid is already obtained or available
                     */
                    if (data[3].ToString() == user.userId.ToLower() && data[4].ToString() == user.password)
                    {
                        saveLoginData(Convert.ToInt32(data[0]));

                        this.Hide();
                        var userPage = new UserProfilePage();
                        userPage.ShowDialog();
                        return;
                    }
                }

                MessageBox.Show("Log in error, please check your userid or password carefully!");
            }
            catch(Exception e)
            {
                // + e.ToString() in message box to show the actual error
                MessageBox.Show("Error has encountered in checkAccount()" + e.ToString());
            }



        }

        //This will check if the userinput has symbol 
        bool checkSymbol()
        {
            Sanitize sanitize = new Sanitize();

            if (sanitize.sanitizeInput(user.userId))
            {
                return false;
            }
            return true;
        }

        //This will get all user input
        void getUserInput()
        {
            user.userId = useridTb.Text;
            //This will sanitized the user input
            if (!checkSymbol())
            {
                MessageBox.Show("Userid contains symbol, please check it carefully");
                return;
            }
            user.password = hashAlgo(passwordTb.Text);

        }


        //This method will check all imput field if there was an empty field
        bool checkEmptyField()
        {
            if (useridTb.Text.Trim() == String.Empty ||
                passwordTb.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please fill all input field correctly");
                return false;
            }

            return true;



        }

        string hashAlgo(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                //From String to byte array
                byte[] sourceBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                return hash;
            }
        }



        //This is the function for show and hide password
        private void showPassBtn_Click(object sender, EventArgs e)
        {

            if (passwordTb.PasswordChar == '*')
            {
                passwordTb.PasswordChar = '\0';
                showPassBtn.BackgroundImage = Image.FromFile("Asset/hide.png");
            }
            else
            {
                passwordTb.PasswordChar = '*';
                showPassBtn.BackgroundImage = Image.FromFile("Asset/show.png");
            }

        }

        //This event is used to create a enter key press function to act as a login button when being pressed
        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;

                loginBtn_Click(sender, null);
            }
        }

        private void useridTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;

            }
        }

        private void appSettingsBtn_Click(object sender, EventArgs e)
        {
            var appSettingsPage = new AppSettingsPage();
            appSettingsPage.ShowDialog();
        }


        private void checkPoint()
        {
            appSettings settings = new appSettings();
            if (String.IsNullOrEmpty(settings.getPassword()))
            {
                MessageBox.Show("Please put the db password first!");
                var AppSettingsPage = new AppSettingsPage();
                AppSettingsPage.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}