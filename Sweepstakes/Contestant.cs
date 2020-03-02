using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public string Email { get { return email; } }
        public int RegistrationNumber { get { return registrationNumber; } }
        private string firstName;
        private string lastName;
        private string email;
        private int registrationNumber;

        public Contestant()
        {

        }
    }
}
