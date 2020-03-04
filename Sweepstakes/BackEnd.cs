using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class BackEnd
    {
        ContestantInformationCollectionTool CICT;
        Uservalidation validation;
        
        public BackEnd()
        {
            validation = new Uservalidation();
            CICT = new ContestantInformationCollectionTool();
            
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
                else if (uchoice == -2) { Console.WriteLine("Please enter an integer"); }
                else if (uchoice == -3) { Console.WriteLine("Please enter a value within the range of options"); }
                if (val == false) { choice = UserInterface.DisplaySweepManagementMethod(); }
            }
            return uchoice;
        }
        public void AddASweeptake(MarketingFirm firmWithManager) 
        {
            firmWithManager.CreateSweepStake();
        }
        public void AddContestant(SweepStakes sweepStake) 
        {
            Contestant contestant = new Contestant();
            contestant = CICT.CreateNewContestant(contestant);
            sweepStake.RegistrContestant(contestant);
        }
        public void DisplayContestantInformation(SweepStakes sweepstake) 
        {
            Contestant contestant = new Contestant();
            for (int i = 1; i < sweepstake.RegistrationNumber + 1; i++)
            {
                contestant = sweepstake.GetContestant(i);
                sweepstake.PrintContestantInfo(contestant);
            }
            Console.Read();
        }

    }
}
