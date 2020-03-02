using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        public static string DisplayEmailCollection(string email) 
        {
            Console.WriteLine("Please enter an email");
            email = Console.ReadLine();
            return email;
        }
        public static string DisplayFirstNameCollection(string firstName)
        {
            Console.WriteLine("Please enter your First Name");
            firstName = Console.ReadLine();
            return firstName;
        }
        public static string DisplayLastNameCollection(string lastName)
        {
            Console.WriteLine("Please enter your Last Name");
            lastName = Console.ReadLine();
            return lastName;
        }
        
    }
}
