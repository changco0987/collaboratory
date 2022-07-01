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
using System.Security.Cryptography;

namespace Collaboratory
{
    public partial class SignupPage : Form
    {

        //This is the model used to store to user input
        private Userdata user = new Userdata();
        private tb_userAccounts conn = new tb_userAccounts();

        bool mousedown; // this is for the draggable panel behavior
        public SignupPage()
        {
            InitializeComponent();

            /*
             * This conditional statement will check if will be use as Edit user info page
             * and if no, This will be function as Sign-up page
             */
            if (UserLoginData.id != 0)
            {
                //all user info to input as a default value to all input field
                pageTitle.Text = "Edit Info";
                firstnameTb.Text = UserLoginData.firstName;
                lastnameTb.Text = UserLoginData.lastName;
                DateTime birthday = DateTime.Parse(UserLoginData.birthday);
                dateTimePicker1.Value = birthday;
                emailTb.Text = UserLoginData.email;
                useridTb.Text = UserLoginData.userId;
                passwordTb.PlaceholderText = "Current Password";


                if (UserLoginData.gender.Equals("Male"))
                {
                    maleRb.Checked = true;
                }
                else if (UserLoginData.gender.Equals("Female"))
                {

                    femaleRb.Checked = true;
                }

            }

        }

        //UI code section
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizedBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //To avoid the screen from stuttering to make the object movement smooth
        public static void enableDoubleBuff(System.Windows.Forms.Control cont)
        {
            System.Reflection.PropertyInfo DemoProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            DemoProp.SetValue(cont, true, null);
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

        private void submitBtn_Click(object sender, EventArgs e)
        {

            //if this method returns true it means that user input all fields correctly

            
            if (!checkEmptyField())
            {
                getUserInput();
            }
            


        }

        /*
         * This method will check the userid and email availability
         * take note that the email must only be linked in 1 collaboratory account
         */
        void checkAccAvailability() 
        {

            try
            {
                List<DataRow> dbData = conn.ReadUser(user);//This will transfer the ReadUser() returned value into dbData

                foreach (var data in dbData)
                {
                    /*
                     * The data index 3 is the location of userid
                     * This will check if the userid is already obtained or available
                     */
                    if (data[3].ToString() == user.userId.ToLower())
                    {
                        MessageBox.Show("Your userid is already used");
                        return;
                    }


                    /*
                    * The data index 9 is the location of email
                    * This will check if the email address is already linked to a user or not
                    */
                    if (data[9].ToString() == user.email)
                    {
                        MessageBox.Show("Your email address is already linked to a user");
                        return;
                    }


                }

                saveAccountInfo(UserLoginData.id);
            }
            catch 
            {
                //This will trigger incase theres an unexpected error then suddenly the connection did not close correctly
                conn.closeConn();
            }
            
        }

        /*
         * This method will check if the user is updating or creating new account.
         * if the id is equal to 0 it means the user is not updating their account
         * and this page also function as sign-up page
         */
        async void saveAccountInfo(int id) 
        {


            Gmail gmail = new Gmail();
            
            if (id == 0)
            {
                //this will insert the new user data into database
                conn.CreateUser(user);
                MessageBox.Show("Account Created Successfully!");


                //Loading screen
                var splashScreen = new LoadingScreen();
                splashScreen.Show();

                await Task.Factory.StartNew(() =>
                {
                    //This will be the email notification to a user to be informed that they linked their email to an collaboratory account
                    string[] msg = gmail.accountCreatedMsg(user.userId);
                    gmail.sendMail(user.email, msg[0], msg[1]);

                });

                splashScreen.Close();


            }
            else 
            {
                //this will update user data into database
                user.id = UserLoginData.id;
                conn.UpdateUser(user);

                //This will be use to remove all saved user data to avoid reusing it
                UserLoginData loginData = new UserLoginData();
                loginData.reset();

                MessageBox.Show("Account Info Updated Successfully!");

                //Loading screen
                var splashScreen = new LoadingScreen();
                splashScreen.Show();

                await Task.Factory.StartNew(() => 
                {
                    //This will be the email notification to a user to be informed that they linked their email to an collaboratory account
                    string[] msg = gmail.accountUpdateMsg(user.userId);
                    gmail.sendMail(user.email, msg[0], msg[1]);
                });

                splashScreen.Close();
            }


            this.Hide();
            var loginPage = new LoginForm();
            loginPage.ShowDialog();
            this.Close();
        }

        //This will check if the userinput has symbol 
        bool checkSymbol()
        {
            Sanitize sanitize = new Sanitize();
            
            if (sanitize.sanitizeInput(user.firstName) ||
                sanitize.sanitizeInput(user.lastName) ||
                sanitize.sanitizeInput(user.email) ||
                sanitize.sanitizeInput(user.userId))
            {
                return false;
            }
            return true;
        }

        //This will get all user input
        void getUserInput() 
        {
            user.firstName = firstnameTb.Text.ToLower().Trim();
            user.lastName = lastnameTb.Text.ToLower().Trim();
            user.birthday = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            user.email = emailTb.Text.ToLower();
            user.userId = useridTb.Text.ToLower().Trim();

            //This will get the gender radio button value
            if (femaleRb.Checked)
            {
                user.gender = femaleRb.Text;
            }
            else if (maleRb.Checked)
            {
                user.gender = maleRb.Text;
            }


            if (passwordTb.Text.Equals(confirmpassTb.Text))
            {
                if (passwordTb.Text.Count() >= 8)
                {
                    //This will sanitized the user input
                    if(!checkSymbol())
                    {
                        MessageBox.Show("Please avoid using symbols in your information");
                        return;
                    }
                    user.password = hashAlgo(passwordTb.Text);
                    /*
                     * This will check first the static model userid if it has data stored or not nullindicating that
                     * this page will be used as Edit info page and if no, it will be function as a Sign-up page
                     * This also check if the user change their userId and email
                     */

                    if (string.IsNullOrEmpty(UserLoginData.userId))
                    {
                        checkAccAvailability();
                    }
                    else
                    {
                        /*
                         * This will check the hash equivalent of inputted password
                         * and the hash password that stored in UserLoginData.password
                         */
                        string inputtedPass = hashAlgo(passwordTb.Text);
                        if (inputtedPass.Equals(UserLoginData.password))
                        {
                            saveAccountInfo(UserLoginData.id);
                        }
                        else 
                        {
                            MessageBox.Show("Incorrect password!");
                            return;
                        }
                    }

                    

                }
                else 
                {
                    MessageBox.Show("Password must at least 8 characters or numbers");
                }
                
            }
            else 
            {
                MessageBox.Show("Password doesn't match!");
            }
        }

        //This method will check all imput field if there was an empty field
        bool checkEmptyField() 
        {
            if (firstnameTb.Text.Trim()==String.Empty ||
                lastnameTb.Text.Trim() == String.Empty ||
                useridTb.Text.Trim() == String.Empty ||
                passwordTb.Text.Trim() == String.Empty ||
                confirmpassTb.Text.Trim() == String.Empty ||
                emailTb.Text.Trim() == String.Empty ||
                (femaleRb.Checked==false && maleRb.Checked==false))
            {
                MessageBox.Show("Please check information carefully");
                return true;
            }

            return false;//This means that there is no empty field
        }

        string hashAlgo(string password) 
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                //From String to byte array
                byte[] sourceBytes = Encoding.UTF8.GetBytes(password.Trim());
                byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                return hash;
            }
        }

        //for Confirm password button
        private void showPassBtn2_Click(object sender, EventArgs e)
        {
            if (confirmpassTb.PasswordChar == '*')
            {
                confirmpassTb.PasswordChar = '\0';
                showPassBtn2.BackgroundImage = Image.FromFile("Asset/hide.png");
            }
            else
            {
                confirmpassTb.PasswordChar = '*';
                showPassBtn2.BackgroundImage = Image.FromFile("Asset/show.png");
            }
        }


        //for password button
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

        //The back button method can direct user in 2 different pages dependent on where user came from
        private void backBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserLoginData.userId))
            {
                this.Hide();
                var backToLogin = new LoginForm();
                backToLogin.ShowDialog();
                this.Close();
            }
            else 
            {
                this.Hide();
                var backToAccountSett = new AccountSettingPage();
                backToAccountSett.ShowDialog();
                this.Close();
            }
        }

        private void confirmpassTb_KeyDown(object sender, KeyEventArgs e)
        {
            //if the user press enter this code block will trigger
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;

                submitBtn_Click(sender,null);//This will call the submitBtn Click event
            }
        }

    }
}
