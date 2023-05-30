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
    internal class tb_updates
    {

        //This is the connection path for the app database (collaboratorydb)
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=collaboratorydb;User Id=postgres;Password=" + appSettings.dbPassword + ";");



        public void CreatePost(Updatedata updates)
        {
            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "insert into tb_updates(title,filename,note,post_datetime,account_id,repository_id)" +
                "values('" + updates.title+ "','" + updates.fileName + "','" + updates.note + "','" + updates.postDatetime + "',"
                + updates.accountId + "," + updates.repositoryId + ")";//sql query to insert from the model to database
            comm.ExecuteNonQuery();
            comm.Dispose();
            conn.Close();
        }

        public List<DataRow> ReadPost(Updatedata updates)
        {

            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;


            if (updates.repositoryId != 0 && updates.accountId != 0)
            {
                //This will trigger to retrieved all user post/updates from specific repository
                comm.CommandText = "select * from tb_updates where account_id = " + updates.accountId +
                    "and repository_id = " + updates.repositoryId;
            }
            else if (updates.id == 0)
            {
                /*
                 * This usually used to retrieved all post/updates from a current repository
                 */
                comm.CommandText = "select * from tb_updates where repository_id = " + updates.repositoryId;
            }
            else
            {
                /*
                 * This usually used to retrieved a specific post/update from a current repository
                 */
                comm.CommandText = "select * from tb_updates where update_id = " + updates.id;
            }


            NpgsqlDataReader reader = comm.ExecuteReader();

            DataTable dt = new DataTable();

            if (reader.HasRows)
            {
                dt.Load(reader);
            }

            List<DataRow> updatelist = dt.AsEnumerable().ToList();//This will transfer all data from DataTable into List
            comm.Dispose();
            conn.Close();

            return updatelist;
        }


        public void UpdatePost(Updatedata update)
        {
            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "update tb_updates set title = '" + update.title + "',filename= '" + update.fileName + "'," +
                "note = '" + update.note + "',post_datetime= '" + update.postDatetime + "' where update_id = " + update.id;//sql query to update user data

            comm.ExecuteNonQuery();
            comm.Dispose();
            conn.Close();
        }

        public void DeletePost(Updatedata update)
        {
            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "delete from tb_updates where update_id = " + update.id;//sql query to delete specific data from database
            comm.ExecuteNonQuery();
            comm.Dispose();
            conn.Close();
        }



    }
}
