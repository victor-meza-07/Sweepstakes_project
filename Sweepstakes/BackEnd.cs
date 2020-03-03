using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class BackEnd
    {
        Uservalidation validation;
        public BackEnd()
        {
            validation = new Uservalidation();
        }

        public int GetDataModeInformation() 
        {
            string choice = UserInterface.DisplaySweepManagementMethod();
            bool val = false;
            int uchoice = 0;
            while (!val)
            {
                val = validation.GetUserValidationFromRangOfNumericalOptions(choice, 1, 2, out uchoice);
                if (uchoice == -1) { Console.WriteLine("Please enter a value on screen"); }
                else if (uchoice == -3) { Console.WriteLine("Please enter a value within the range of options"); }
                if (val == false) { choice = UserInterface.DisplaySweepManagementMethod(); }
            }
            return uchoice;
        }
    }
}
