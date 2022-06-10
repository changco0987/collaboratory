using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collaboratory.Model
{
    public class Messagedata
    {
        public int id { get; set; }
        public string message { get; set; }
        public string sentDate { get; set; }
        public int accountId { get; set; }
        public int groupchatId { get; set; }
    }
}
