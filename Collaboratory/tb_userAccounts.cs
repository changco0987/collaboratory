using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Collaboratory.Model;
using Npgsql;
using System.Collections.ObjectModel;

namespace Collaboratory
{
    public class tb_userAccounts
    {

        //This is the connection path for the app database (collaboratorydb)
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=collaboratorydb;User Id=postgres;Password=123;");



        public void CreateUser(Userdata user)
        {
            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "insert into tb_useraccounts(firstname,lastname,userid,password,birthday,gender,profilepicname,uak,email)" +
                "values('"+user.firstName+ "','" + user.lastName+ "','" + user.userId + "','" + user.password + "','"
                + user.birthday + "','" + user.gender + "','" + user.profilePicName + "','" + user.uak + "','" + user.email + "')";//sql query to insert from the model to database
            comm.ExecuteNonQuery();
            comm.Dispose();
            conn.Close();
        }

        public List<DataRow> ReadUser(Userdata user)
        {

            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;


            if (user.id == 0 && String.IsNullOrEmpty(user.email))
            {
                comm.CommandText = "select * from tb_useraccounts";//sql query to retrieve all data from database
            }
            else if (!String.IsNullOrEmpty(user.email)) 
            {
                // sql query to retrieve data of specific email from database
                comm.CommandText = "select * from tb_useraccounts where email = '" + user.email + "';";
            }
            else
            {
                //sql query to retrieve data of specific id from database
                comm.CommandText = "select * from tb_useraccounts where account_id = " + user.id + ";";
            }

            NpgsqlDataReader reader = comm.ExecuteReader();

            DataTable dt = new DataTable();

            if (reader.HasRows)
            {
                dt.Load(reader);
                
            }
            List<DataRow> userlist = dt.AsEnumerable().ToList();//This will transfer all data from DataTable into List
            comm.Dispose();
            conn.Close();

            return userlist;
        }


        public void UpdateUser(Userdata user) 
        {
            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "update tb_useraccounts set firstname = '"+user.firstName+ "',lastname= '" + user.lastName + "'," +
                "userid= '" + user.userId + "',password= '" + user.password + "',birthday= '" + user.birthday + "'," +
                "gender= '" + user.gender + "',profilepicname= '" + user.profilePicName +"',uak= '" + user.uak + "',email= '" + user.email +
                "' where account_id = " +user.id+"";//sql query to update user data

            comm.ExecuteNonQuery();
            comm.Dispose();
            conn.Close();
        }

        public void DeleteUser(Userdata user) 
        {
            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "delete from tb_useraccounts where account_id = "+user.id+"";//sql query to delete specific data from database
            comm.ExecuteNonQuery();
            comm.Dispose();
            conn.Close();
        }

        /*
         * This is the search method
         * the first parameter is used to get the data from database or the data that we query
         * the second parameter is used as a search input
         */
        public List<Userdata> search(ObservableCollection<Userdata> userdata, string name)
        {

            var filteredList = userdata.Where(a => a.firstName.StartsWith(name) || a.lastName.StartsWith(name));
            

            return filteredList.ToList();
        }


        public void closeConn()
        {
            conn.Dispose();
            conn.Close();
        } 

        //public List<DataRow> getUsername() 
        //{
        //    conn.Open();

        //    NpgsqlCommand comm = new NpgsqlCommand();
        //    comm.Connection = conn;
        //    comm.CommandType = CommandType.Text;
        //    comm.CommandText = "select * from tb_useraccounts";//sql query

        //    NpgsqlDataReader reader = comm.ExecuteReader();

        //    Userdata userdata = new Userdata();
        //    DataTable dt = new DataTable();

        //    //this will check if there was a data from query
        //    if (!reader.HasRows)
        //    {
        //        return null;
        //    }

        //    dt.Load(reader);
        //    List<DataRow> list = dt.AsEnumerable().ToList();
        //    UserdataList model = new UserdataList();
        //    //model.users = list.ToList();
            
        //    comm.Dispose();
        //    conn.Close();
        //    return list;
        //}
        
        //public DataTable userdbConn()
        //{

        //    conn.Open();

        //    NpgsqlCommand comm = new NpgsqlCommand();
        //    comm.Connection = conn;
        //    comm.CommandType = CommandType.Text;
        //    comm.CommandText = "select firstname from tb_useraccounts";//sql query

        //    NpgsqlDataReader reader = comm.ExecuteReader();

        //    DataTable dt = new DataTable();
            
        //    string col1;
        //    if (reader.HasRows) 
        //    {
        //        dt.Load(reader);
        //    }
        //    comm.Dispose();
        //    conn.Close();

        //    return dt;
        //}
    }
}
