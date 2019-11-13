using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string managerType = UserInterface.ChooseStackOrQueue();
            ISweepstakesManager manager;
            if (managerType == "stack")
            {
                manager = new SweepstakesStackManager();
            }
            else if (managerType == "queue")
            {
                manager = new SweepstakesQueueManager();
            }
            else
            {
                return;
            }
           
        }
    }
}
