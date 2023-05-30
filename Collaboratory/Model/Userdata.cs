using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace Collaboratory.Model
{
    public class Userdata
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userId { get; set; }
        public string password { get; set; }
        public string birthday { get; set; }
        public string gender { get; set; }
        public string profilePicName { get; set; }
        public string uak { get; set; }
        public string email { get; set; }


        //This will transfer all data from static UserLoginData model to non static UserData model
        public Userdata statModelToModel(Userdata user)
        {
            user.id = UserLoginData.id;
            user.firstName = UserLoginData.firstName;
            user.lastName = UserLoginData.lastName;
            user.userId = UserLoginData.userId;
            user.password = UserLoginData.password;
            user.birthday = UserLoginData.birthday;
            user.gender = UserLoginData.gender;
            user.profilePicName = UserLoginData.profilePicName;
            user.uak = UserLoginData.uak;
            user.email = UserLoginData.email;

            return user;
        }

    }


    public class UserLoginData
    {
        public static int id { get; set; }
        public static string firstName { get; set; }
        public static string lastName { get; set; }
        public static string userId { get; set; }
        public static string password { get; set; }
        public static string birthday { get; set; }
        public static string gender { get; set; }
        public static string profilePicName { get; set; }
        public static string uak { get; set; }
        public static string email { get; set; }

        public void reset()
        {
            id = 0;
            firstName = "";
            lastName = "";
            userId = "";
            password = "";
            birthday = "";
            gender = "";
            profilePicName = "";
            uak = "";
            email = "";
        }

    }
    public class UserdataList 
    {
        public static List<Userdata> users { get; set; }
    }
}
