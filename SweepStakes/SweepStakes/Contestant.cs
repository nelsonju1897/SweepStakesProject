using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Contestant 
    {
        //member variables
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;

        //constructor
        public Contestant()
        {
            firstName = UserInterface.addFirstName();
            lastName = UserInterface.addLastName();
            emailAddress = UserInterface.addEmailAddress();
            registrationNumber = UserInterface.addRegistrationNumber();
        }

        //member methods

        public void DisplayContestantInfo()
        {
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(emailAddress);
            Console.WriteLine(registrationNumber);
        }
    }
}
