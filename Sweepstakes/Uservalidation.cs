using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
                if ((email.Substring(0,atSpace) != "") && email.Substring(0, atSpace) != ".") 
                {
                    validated = true;
                }
            }
            return validated;
        }
        public string ReturnCapitalizedAndFormatedName(string name) 
        {
            name.Replace(" ", String.Empty);
            char firstChar = name[0];
            string charAsString = firstChar.ToString();
            name.Replace(charAsString, charAsString.ToUpper());

            return name;
        }
        public bool GetUserValidationFromRangOfNumericalOptions(string userchocie, int minChoice, int maxChoice, out int choice) 
        {
            bool validated = false;
            choice = -1;
            try { Int32.Parse(userchocie); }
            catch (Exception) 
            {
                choice = -2;//not an int
            }
            if (minChoice == choice || choice <= maxChoice) 
            {
                validated = true;
                choice = Int32.Parse(userchocie);
            }
            else
            {
                choice = -3;//not in range
            }

            return validated;
        }
    }
}
