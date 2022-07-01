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
    public partial class ResetPassPage : Form
    {
        Userdata user = new Userdata();


        bool mousedown; // this is for the draggable panel behavior
        public ResetPassPage()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            enableDoubleBuff(this);

            useridTb.Text = UserLoginData.userId;
        }


        /*
         * The code below is the form UI functions
         */


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
        private void resetBtn_Click(object sender, EventArgs e)
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
                        user = user.statModelToModel(user);
                        user.password = hashAlgo(passwordTb.Text);//Assign new password to the model
                        checkUAK(user.uak);
                        Gmail mail = new Gmail();

                        //This will send the account notification to the user
                        mail.sendMail(user.email, mail.passwordUpdateNotif(user.userId)[0], mail.passwordUpdateNotif(user.userId)[1]);

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
                        return;
                    }


                }
                else 
                {
                    MessageBox.Show("Your password doesn't match, please check carefully!");
                    return;
                }
            }
            
        }

        //It will check your inputted UAK if its correct, then update your information to the database
        void checkUAK(string uak) 
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
                    return;
                }
            }

            MessageBox.Show("Incorrect UAK, please check your UAK in your email carefully");
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

    }
}
