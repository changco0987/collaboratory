using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using Collaboratory.Model;

namespace Collaboratory
{
    public class tb_messages
    {
        //This is the connection path for the app database (collaboratorydb)
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=collaboratorydb;User Id=postgres;Password=123;");

        public void CreateMessage(Messagedata messageData)
        {

            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "insert into tb_messages(message,account_id,groupchat_id) values('" + messageData.message +
                "',"+ messageData.accountId +","+ messageData.groupchatId +")";//sql query to insert from the model to database
            comm.ExecuteNonQuery();
            comm.Dispose();
            conn.Close();
        }

        /*
         * if used = user it means it will query using the user account id
         * if used = repo it means it will query using the repo id
         */
        public List<DataRow> ReadMessage(Messagedata messageData)
        {
            try
            {
                conn.Open();

                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;

                comm.CommandText = "select * from tb_messages where groupchat_id =" + messageData.groupchatId;//sql query to retrieve all data from database



                NpgsqlDataReader reader = comm.ExecuteReader();

                DataTable dt = new DataTable();

                if (reader.HasRows)
                {
                    dt.Load(reader);

                }
                List<DataRow> messagesData = dt.AsEnumerable().ToList();//This will transfer all data from DataTable into List
                comm.Dispose();
                conn.Close();

                return messagesData;
            }
            catch 
            {
                EmergencyCleaner();
                return ReadMessage(messageData);
            }


           
        }

        public void UpdateMessage(Messagedata messageData)
        {
            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "update tb_messages set message = '" + messageData.message + "where groupchat_id= '" + messageData.groupchatId;//sql query to update repository data

            comm.ExecuteNonQuery();
            comm.Dispose();
            conn.Close();
        }

        public void DeleteMessage(Messagedata messageData)
        {
            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "delete from tb_messages where groupchat_id = " + messageData.groupchatId;//sql query to delete specific data from database
            comm.ExecuteNonQuery();
            comm.Dispose();
            conn.Close();
        }

        public void EmergencyCleaner() 
        {
            try
            {
                conn.Close();
            }
            catch
            {
                //This will occur incase the conn.Close() fail
                conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=collaboratorydb;User Id=postgres;Password=123;");
            }
        }
    }
}
