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

namespace Collaboratory
{
    public partial class authenticationPage : Form
    {
        bool mousedown; // this is for the draggable panel behavior
        Userdata user = new Userdata();
        tb_userAccounts tb_User = new tb_userAccounts();

        public authenticationPage()
        {
            InitializeComponent();
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
            this.Close();
        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var backToLogin = new LoginForm();
            backToLogin.ShowDialog();
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

        private void reqcodeBtn_Click(object sender, EventArgs e)
        {
            if (!checkEmptyField())
            {
                assignAllDbDataToModel();
            }

           
        }

        bool checkEmptyField() 
        {
            //This will check if the textbox was empty or not
            if (emailTb.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please Enter your");
                return true;
            }
            return false;//This means that there is no empty field
        }



        void assignAllDbDataToModel()
        {
            List<DataRow> dbData = tb_User.ReadUser(user);//This will send the user.email data to find data linked to the inputted email address

            foreach (var data in dbData)
            {
                //This will check if your inputted email is linked/registered to a userid
                if (data[9].ToString() == emailTb.Text.ToLower())
                {
                    //To get all default user data and assign it to Userdata model
                    user.id = Convert.ToInt32(data[0]);
                    user.firstName = data[1].ToString();
                    user.lastName = data[2].ToString();
                    user.userId = data[3].ToString();
                    user.password = data[4].ToString();
                    user.birthday = data[5].ToString();
                    user.gender = data[6].ToString();
                    user.profilePicName = data[7].ToString();
                    user.email = data[9].ToString();


                    Random rnd = new Random();
                    int randomCode = rnd.Next(11111111, 99999999);//This is the UAK the will be sended to a user everytime they request it

                    user.uak = randomCode.ToString();//This will assign the new UAK to the user.uak

                    assignDataToStatModel();//This will assign all data to static model to use the data in the next form/page

                    tb_User.UpdateUser(user);//This will update the user uak data in database

                    Gmail mail = new Gmail();
                    //This is the email function that the user will be recieve
                    mail.sendMail(user.email, mail.resetCodeMsg(randomCode)[0], mail.resetCodeMsg(randomCode)[1]);

                    MessageBox.Show("Code sent successfully!");
                    this.Hide();
                    var openResetPage = new ResetPassPage();
                    openResetPage.ShowDialog();
                }
            }
            MessageBox.Show("There's no userid linked in your email address");
            return;
        }

        void assignDataToStatModel() 
        {
            UserLoginData.id = user.id;
            UserLoginData.firstName = user.firstName;
            UserLoginData.lastName = user.lastName;
            UserLoginData.userId = user.userId;
            UserLoginData.password = user.password;
            UserLoginData.birthday = user.birthday;
            UserLoginData.gender = user.gender;
            UserLoginData.profilePicName = user.profilePicName;
            UserLoginData.uak = user.uak;
            UserLoginData.email = user.email;
        }


    }
}
