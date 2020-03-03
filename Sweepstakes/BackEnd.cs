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

        public void GetDataModeInformation() 
        {
            string choice = UserInterface.DisplaySweepManagementMethod();
            bool val = false;
            int uchoice;
            while (!val)
            {
                val = validation.GetUserValidationFromRangOfNumericalOptions(choice, 1, 2, out uchoice);
            }
        }
    }
}
