using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collaboratory.Model
{
    public class appSettings
    {
        private string fileLocation = @"\key.txt";//This is the file were the db password stored in local computer
        private static string dbPassword = "";

        public appSettings() 
        {
            if (string.IsNullOrEmpty(dbPassword))
            {
                setPassword(checkKey());
            }
        }

        public void setPassword(string password) 
        {
            dbPassword = writeKey(password);
        }

        public string getPassword() 
        {
            return dbPassword;
        }

        private string writeKey(string password) 
        {
            System.IO.File.WriteAllText(Application.UserAppDataPath + fileLocation, password);//this will write or overwrite txt file data
            return password;
        }

        private string checkKey()
        {
            string fileData = "";
            try
            {

                if (File.Exists(Application.UserAppDataPath + fileLocation))
                {
                    //check if there is existing file and it have a data inside
                    using (FileStream scanToRead = new FileStream(Application.UserAppDataPath + fileLocation, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    {
                        StreamReader readFile = new StreamReader(scanToRead);
                        fileData = readFile.ReadLine();
                        readFile.Close();
                        scanToRead.Close();
                    }
                    return fileData;
                }
                else
                {
                    return null;
                }


            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
        }

    }
}
