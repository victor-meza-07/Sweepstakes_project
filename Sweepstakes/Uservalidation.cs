using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Uservalidation
    {
        public bool ValidateEmail(string email) 
        {
            bool validated = false;
            int atSpace;
            if (email.Contains(".") && email.Contains("@") && !(email.Contains(" ")) && email != null) 
            {
                atSpace = email.IndexOf("@");
                if (email.Substring(0,atSpace) != "") 
                {
                    validated = true;
                }
            }
            return validated;
        }
    }
}
