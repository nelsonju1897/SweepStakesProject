using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class MarketingFirm
    {
        //member variables
        public ISweepstakesManager manager;

        //constructor
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }

        //member methods
        public void MakeSweepstakesManager()
        {
            string managerType = UserInterface.ChooseStackOrQueue();
            if (managerType == "stack")
            {
                manager = new SweepstakesStackManager();
            }
            else if(managerType == "queue")
            {
                manager = new SweepstakesQueueManager();
            }
            else
            {
                return;
            }
        }

        public void MakeSweepstake()
        {
            string sweepstakesName = UserInterface.ChooseSweepstakesName();
            Sweepstakes newSweepstake = new Sweepstakes(sweepstakesName);
            manager.InsertSweepstakes(newSweepstake);
        }
    }
}
