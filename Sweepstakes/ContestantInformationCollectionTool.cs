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





        public void CreateNewContestant(Contestant contestant) 
        {
            contestant.FirstName = CollectFirstName();
            contestant.LastName = CollectLastName();
            contestant.Email = CollectValidatedEmail();
        }

        private string CollectValidatedEmail()
        {
            string email = "";
            bool validated = false;
            while (!validated) 
            {
                email = UserInterface.DisplayEmailCollection(email);
                validated = val.ValidateEmail(email);
            }

            return email;
        }
        private string CollectFirstName() 
        {
            string firstName = "";
            firstName = UserInterface.DisplayFirstNameCollection(firstName);
            firstName = val.ReturnCapitalizedAndFormatedName(firstName);
            return firstName;
        }
        private string CollectLastName() 
        {
            string lastName = "";
            lastName = UserInterface.DisplayFirstNameCollection(lastName);
            lastName = val.ReturnCapitalizedAndFormatedName(lastName);
            return lastName;
        }
    }
}
