using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collaboratory
{
    public class Sanitize
    {
        //this will check if the user input has symbol
        public bool sanitizeInput(string input) 
        {
            char[] danger = { '*', '(', ')', '[', ']', ';', ':','$','{','}','\''};

            foreach (char symbols in danger) 
            {
                if (input.Contains(symbols)) 
                {
                    return input.Contains(symbols);
                }
            }
            return false;
        }
    }
}
