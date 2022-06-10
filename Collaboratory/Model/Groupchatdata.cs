using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collaboratory.Model
{
    public class Groupchatdata
    {
        public int id { get; set; }
        public int repositoryId { get; set; }
    }

    public class currentGroupchat 
    {
        public static int id { get; set; }
        public static int repositoryId { get; set; }

        public void reset() 
        {
            id = 0;
            repositoryId = 0;
        }

    }
}
