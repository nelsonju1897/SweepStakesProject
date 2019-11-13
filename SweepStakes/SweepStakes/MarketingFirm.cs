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

        public void MakeSweepstake()
        {
            string sweepstakesName = UserInterface.ChooseSweepstakesName();
            Sweepstakes newSweepstake = new Sweepstakes(sweepstakesName);
            manager.InsertSweepstakes(newSweepstake);
        }
        public void StartNextSweepstake()
        {
            Sweepstakes sweep = manager.GetSweepstakes();
            Contestant contestant = sweep.PickWinner();
            UserInterface.DisplayWinner(contestant, sweep);
        }
    }
}
