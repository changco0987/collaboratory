using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collaboratory.Model
{
    public class Updatedata
    {
        public int id { get; set; }
        public string title { get; set; }
        public string fileName { get; set; }
        public string note { get; set; }
        public string postDatetime { get; set; }
        public int accountId { get; set; }
        public int repositoryId { get; set; }


        //This will transfer all data from static SelectedUpdateData model to non static UpdateData model
        public Updatedata statModelToModel(Updatedata update)
        {
            update.id = SelectedUpdateData.id;
            update.title = SelectedUpdateData.title;
            update.fileName = SelectedUpdateData.fileName;
            update.note = SelectedUpdateData.note;
            update.postDatetime = SelectedUpdateData.postDatetime;
            update.accountId = SelectedUpdateData.accountId;
            update.repositoryId = SelectedUpdateData.repositoryId;

            return update;
        }

    }


    public class SelectedUpdateData
    {
        public static int id { get; set; }
        public static string title { get; set; }
        public static string fileName { get; set; }
        public static string note { get; set; }
        public static string postDatetime { get; set; }
        public static int accountId { get; set; }
        public static int repositoryId { get; set; }

        public void reset()
        {
            id = 0;
            title = "";
            fileName = "";
            note = "";
            postDatetime = "";
            accountId = 0;
            repositoryId = 0;
        }


    }
}
