using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collaboratory.Model
{
    public class Repodata
    {
        public int id { get; set; }
        public string repositoryName { get; set; }
        public List<int> members { get;set; }
        public int accountId { get; set; }


        //This will transfer all data from static selectedRepoData model to non static RepoData model
        public Repodata statModelToModel(Repodata repo)
        {
            repo.id = SelectedRepoData.id;
            repo.repositoryName = SelectedRepoData.repositoryName;
            repo.members = SelectedRepoData.members.ToList();
            repo.accountId = SelectedRepoData.accountId;

            return repo;
        }

    }
    public class SelectedRepoData
    {
        public static int id { get; set; }
        public static string repositoryName { get; set; }
        public static List<int> members { get; set; }
        public static int accountId { get; set; }

        public void reset()
        {
            id = 0;
            repositoryName = "";
            members.Clear();
            accountId = 0;
        }


    }
}

