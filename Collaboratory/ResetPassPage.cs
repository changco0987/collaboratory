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
using System.Runtime.InteropServices;


namespace Collaboratory
{
    public partial class ResetPassPage : Form
    {
        Userdata user = new Userdata();


        bool mousedown; // this is for the draggable panel behavior
        public ResetPassPage()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.DoubleBuffered = true;
            enableDoubleBuff(this);

            useridTb.Text = UserLoginData.userId;
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


        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var backToAuthPage = new authenticationPage();

            backToAuthPage.ShowDialog();
            this.Close();
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
        private async void resetBtn_Click(object sender, EventArgs e)
        {
            if (!checkEmptyField()) 
            {
                /*
                 * This will check if the password you inputted is equal to confirm password textbox
                 * And also to check if your password lenght is at least 8 in count
                 */
                if (passwordTb.Text == confirmpassTb.Text)
                {
                    if (passwordTb.Text.Count() >= 8)
                    {

                        //Loading screen
                        var splashScreen = new LoadingScreen();
                        splashScreen.Show();
                        user = user.statModelToModel(user);
                        user.password = hashAlgo(passwordTb.Text);//Assign new password to the model
                        if (!checkUAK(uakTb.Text))
                        {
                            splashScreen.Close();
                            MessageBox.Show("Incorrect UAK, please check your UAK in your email carefully");

                            //This will jus remove the unexpected spaces incase the user failed to input a their password
                            passwordTb.Text = passwordTb.Text.Trim();
                            confirmpassTb.Text = confirmpassTb.Text.Trim();
                            return;
                        }

                        await Task.Factory.StartNew(() =>
                        {

                            Gmail mail = new Gmail();

                            //This will send the account notification to the user
                            mail.sendMail(user.email, mail.passwordUpdateNotif(user.userId)[0], mail.passwordUpdateNotif(user.userId)[1]);
                        });
                        
                        splashScreen.Close();

                        MessageBox.Show("Password updated successfully!");

                        this.Hide();
                        var backToLogin = new LoginForm();
                        backToLogin.ShowDialog();
                        this.Close();
                        return;
                        
                    }
                    else
                    {
                        MessageBox.Show("Password must at least 8 characters or numbers");
                        
                    }


                }
                else 
                {
                    MessageBox.Show("Your password doesn't match, please check carefully!");
                    
                }
            }
            //This will jus remove the unexpected spaces incase the user failed to input a their password
            passwordTb.Text = passwordTb.Text.Trim();
            confirmpassTb.Text = confirmpassTb.Text.Trim();
            
        }

        //It will check your inputted UAK if its correct, then update your information to the database
        bool checkUAK(string uak) 
        {
            tb_userAccounts tb_User = new tb_userAccounts();
            List<DataRow> dbData = tb_User.ReadUser(user);

            foreach (var data in dbData)
            {
                //this will check if your inputted UAK is equal to the assigned UAK on your account
                if (data[8].ToString() == uak)
                {
                    user.uak = "";//this will remove the assigned UAK to avoid reusing it
                    tb_User.UpdateUser(user);
                    return true;
                }
            }

            return false;
        }

        bool checkEmptyField()
        {
            //This will check if the textbox was empty or not
            if (passwordTb.Text.Trim() == String.Empty ||
                confirmpassTb.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please Enter your password");
                return true;
            }

            if (uakTb.Text.Trim() == String.Empty) 
            {
                MessageBox.Show("Please enter your UAK");
                return true;
            }
            return false;//This means that there is no empty field
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

        private void confirmpassTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;

                resetBtn_Click(sender, null);
            }
        }

        private void passwordTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;


            }
        }
    }
}
