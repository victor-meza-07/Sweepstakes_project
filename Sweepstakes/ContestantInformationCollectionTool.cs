using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Sweepstakes
{
    
    class ContestantInformationCollectionTool
    {
        Uservalidation val;
        public ContestantInformationCollectionTool()
        {
            val = new Uservalidation();
        }
        public void CollectValidatedEmail()
        {
            string email = "";
            bool validated = false;
            while (!validated) 
            {
                email = UserInterface.DisplayEmailCollection(email);
                validated = val.ValidateEmail(email);
            }
            

        }
    }
}
