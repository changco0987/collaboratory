using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Collaboratory.Model;
using Npgsql;

namespace Collaboratory
{
    internal class tb_groupChats
    {


        //Class constructor
        public tb_groupChats() 
        {
            appSettings settings = new appSettings();
            conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=collaboratorydb;User Id=postgres;Password=" + settings.getPassword() + ";");
        }


        //This is the connection path for the app database (collaboratorydb)
        NpgsqlConnection conn;

        public void CreateGC(Groupchatdata groupchat)
        {
            
            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "insert into tb_groupchats(repository_id) values(" + groupchat.repositoryId + ")";//sql query to insert from the model to database
            comm.ExecuteNonQuery();
            comm.Dispose();
            conn.Close();
        }

        /*
         * if used = user it means it will query using the user account id
         * if used = repo it means it will query using the repo id
         */
        public List<DataRow> ReadGC(Groupchatdata groupchat)
        {

            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;

            comm.CommandText = "select * from tb_groupchats where repository_id =" + groupchat.repositoryId;//sql query to retrieve all data from database



            NpgsqlDataReader reader = comm.ExecuteReader();

            DataTable dt = new DataTable();

            if (reader.HasRows)
            {
                dt.Load(reader);

            }
            List<DataRow> groupData = dt.AsEnumerable().ToList();//This will transfer all data from DataTable into List
            comm.Dispose();
            conn.Close();

            return groupData;
        }

        public void UpdateGC(Groupchatdata groupchat)
        {
            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "update tb_groupchats set repository_id = '" + groupchat.repositoryId + "where groupchat_id= '" + groupchat.id;//sql query to update repository data

            comm.ExecuteNonQuery();
            comm.Dispose();
            conn.Close();
        }

        public void DeleteGC(Groupchatdata groupchat)
        {
            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "delete from tb_groupchats where repository_id = " + groupchat.repositoryId;//sql query to delete specific data from database
            comm.ExecuteNonQuery();
            comm.Dispose();
            conn.Close();
        }
    }
}
