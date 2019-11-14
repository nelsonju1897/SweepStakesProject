using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public static class UserInterface
    {
        //member variables
        public static int registratrationNumber;


        //constructor

        //member methods
        public static string addFirstName()
        {
            Console.WriteLine("Please enter contestants first name.");
            string firstName = Console.ReadLine();
            return firstName;
        }
        public static string addLastName()
        {
            Console.WriteLine("Please enter contestants last name.");
            string lastName = Console.ReadLine();
            return lastName;
        }
        public static string addEmailAddress()
        {
            Console.WriteLine("Please enter contestants email address name.");
            string emailAddress = Console.ReadLine();
            return emailAddress;
        }

        public static int addRegistrationNumber()
        {
            registratrationNumber += 1;
            Console.WriteLine("Your registration number is " + registratrationNumber);
            return registratrationNumber;
        }

        public static string ChooseStackOrQueue()
        {
            
            while (true)
            {
                Console.WriteLine("Do you want to stack or queue your sweepstakes? Type: Stack or Queue.");
                string choice = Console.ReadLine();
                
                if (choice.ToLower() == "stack" || choice.ToLower() == "queue")
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Incorrect choice entered.");
                }
            }
            
        }

        public static string ChooseSweepstakesName()
        {
            Console.WriteLine("What do you want to name your Sweepstakes?");
            string choice = Console.ReadLine();
            return choice;
        }

        public static void DisplayWinner(string contestant, string sweep)
        {
            Console.WriteLine("The winner for " + sweep + " is " + contestant);    
        }

    }
}
