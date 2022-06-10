using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collaboratory.Model;
using Npgsql;

namespace Collaboratory
{
    internal class tb_groupChats
    {
        //This is the connection path for the app database (collaboratorydb)
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=collaboratorydb;User Id=postgres;Password=123;");

        public void CreateRepo(Repodata repository)
        {

            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "insert into tb_repositories(repositoryname,members,account_id)" +
                "values('" + repository.repositoryName + "',ARRAY[" + memberList(repository.members) + "]," + repository.accountId + ")";//sql query to insert from the model to database
            comm.ExecuteNonQuery();
            comm.Dispose();
            conn.Close();
        }

        /*
         * if used = user it means it will query using the user account id
         * if used = repo it means it will query using the repo id
         */
        public List<DataRow> ReadRepo(string used, int id)
        {

            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;

            if (used.Equals("user"))
            {
                comm.CommandText = "select * from tb_repositories where " + id + " = any(members)";//sql query to retrieve all data from database
            }
            else if (used.Equals("repo"))
            {
                comm.CommandText = "select * from tb_repositories where repository_id = " + id;//sql query to retrieve all data from database
            }



            NpgsqlDataReader reader = comm.ExecuteReader();

            DataTable dt = new DataTable();

            if (reader.HasRows)
            {
                dt.Load(reader);

            }
            List<DataRow> repolist = dt.AsEnumerable().ToList();//This will transfer all data from DataTable into List
            comm.Dispose();
            conn.Close();

            return repolist;
        }

        public void UpdateRepo(Repodata repository)
        {
            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "update tb_repositories set repositoryname = '" + repository.repositoryName + "',members= '{" + memberList(repository.members) + "}'" +
                "where repository_id= '" + repository.id + "'";//sql query to update repository data

            comm.ExecuteNonQuery();
            comm.Dispose();
            conn.Close();
        }

        public void DeleteRepo(Repodata repository)
        {
            conn.Open();

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "delete from tb_useraccounts where account_id = " + repository.id + "";//sql query to delete specific data from database
            comm.ExecuteNonQuery();
            comm.Dispose();
            conn.Close();
        }
    }
}
