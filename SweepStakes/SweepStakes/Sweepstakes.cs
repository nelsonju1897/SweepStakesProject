using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Sweepstakes
    {
        //member variables
        Random randNumber = new Random();
        Dictionary<int, Contestant> contestantDict;

        //constructor
        public Sweepstakes(string name)
        {
            contestantDict = new Dictionary<int, Contestant>();
        }
        //member methods
        public void RegisterContestant(Contestant contestant)
        {
            contestantDict.Add(contestant.registrationNumber, contestant);
        }

        public Contestant PickWinner()
        {
            int winningNumber = randNumber.Next(1, contestantDict.Count + 1);
            Contestant contestant = contestantDict[winningNumber];
            return contestant;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.firstName);
            Console.WriteLine(contestant.lastName);
            Console.WriteLine(contestant.emailAddress);
            Console.WriteLine(contestant.registrationNumber);
        }
    }
}
