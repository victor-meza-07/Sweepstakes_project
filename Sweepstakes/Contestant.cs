using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int RegistrationNumber { get { return registrationNumber; } }
        
        private int registrationNumber;

        public Contestant()
        {
        }

        public void SetContestantRegNumber(int regNumber) 
        {
            this.registrationNumber = regNumber;
        }
    }
}
