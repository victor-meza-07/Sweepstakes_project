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
    }
}
