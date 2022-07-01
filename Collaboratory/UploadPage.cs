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
    public partial class UploadPage : Form
    {

        Updatedata update = new Updatedata();//This is were the user update store
        bool mousedown; // this is for the draggable panel behavior

        //All variable for file upload
        private string storagePath;
        private string webStoragePath = @"C:\xampp\htdocs\server\repoFile_id" + SelectedRepoData.id + "\\";
        private string fileName;
        private string fileOrigin;
        private string fileExtension;
        public UploadPage()
        {
            InitializeComponent();
            fileName = "";
            storagePath = Application.UserAppDataPath + @"\repoFile_id" + SelectedRepoData.id + "\\";
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!checkEmptyField() && getUserInput())
            {
                saveUpdate();
            }
        }

        //This method will check all imput field if there was an empty field
        bool checkEmptyField()
        {
            if (titleTb.Text.Trim() == String.Empty)
            {
                MessageBox.Show("You can't create a post without a title");
                return true;
            }

            return false;//This means that there is no empty field

        }
        //This will check if the userinput has symbol 
        bool checkSymbol()
        {
            Sanitize sanitize = new Sanitize();

            if (sanitize.sanitizeInput(update.title) ||
                sanitize.sanitizeInput(update.note))
            {
                return false;
            }
            return true;
        }

        //This will get all user input
        bool getUserInput() 
        {
            update.title = titleTb.Text;
            update.note = noteTb.Text;
            update.postDatetime = DateTime.Now.ToString();
            update.accountId = UserLoginData.id;
            update.repositoryId = SelectedRepoData.id;
            update.fileName = fileName;
            if (!checkSymbol())
            {
                MessageBox.Show("Please avoid using symbols in your repository name");
                return false;
            }
            return true;
        }

        async void saveUpdate() 
        {
            tb_updates conn = new tb_updates();

            //loading screen
            var splashScreen = new LoadingScreen();
            splashScreen.Show();

            await Task.Factory.StartNew(()=> 
            {
                //This will check if the user attach a file and if not it will not move the file to the path
                if (fileName.Trim() != String.Empty)
                {
                    File.Copy(fileOrigin, storagePath + fileName, false);//this is the windows app version storage
                    Thread.Sleep(500);
                    File.Copy(fileOrigin, webStoragePath + fileName, false);//this is the web app version storage
                }
            });

            splashScreen.Close();


            conn.CreatePost(update);

            this.Hide();

            this.Close();


        }

        private void noteTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (noteTb.Text.Count() <= 280)
            {

                letterCountLb.Text = noteTb.Text.Count() + "/" + noteTb.MaxLength;
            }
            else
            {
                letterCountLb.ForeColor = Color.Red;
            }
        }

        private void uploadFileBtn_Click(object sender, EventArgs e)
        {
            try
            {

                using (OpenFileDialog open = new OpenFileDialog())
                {
                    //This will check and create a path for img storage
                    if (!Directory.Exists(storagePath))
                    {
                        Directory.CreateDirectory(storagePath);

                    }  
                    
                    //this is the web app version storage path
                    if (!Directory.Exists(webStoragePath))
                    {
                        Directory.CreateDirectory(webStoragePath);

                    }


                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        fileOrigin = open.FileName;
                        fileExtension = Path.GetExtension(fileOrigin);
                        fileName = Path.GetFileName(fileOrigin);//This is were the final file name inputted

                        //This will check if the fileName is not more than 50 character
                        if (fileName.Count() > 50)
                        {
                            //This will trim the fileName
                            fileName = fileName.Substring(0, 40) + fileExtension;

                        }

                        string tempFileName = fileName;//This is just a container for renaming and checking if file exist
                        /*
                         * This will also check if the file is already exist in the directory
                         * since our algo does not overrite the existing file
                         */

                        int fileCount = 1;
                        while (File.Exists(storagePath + tempFileName))
                        {
                            /*
                             * This will reassemble the file name and insert the (n) count, 
                             * depends on the file count in the same file directory
                             */
                            tempFileName = fileName.Substring(0,fileName.IndexOf('.')) + "(" + fileCount + ")" + fileExtension;
                            fileCount++;
                        }

                        fileName = tempFileName;//This is to finalize the fileName
                        filenameLb.Text = fileName;//This is to show the filename to UI


                        open.Dispose();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Error has encountered");
            }
            
                
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
