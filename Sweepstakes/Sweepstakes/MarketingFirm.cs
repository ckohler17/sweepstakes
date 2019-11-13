using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        public ISweepstakesManager manager;
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }
        public void CreateSweepstakes(Contestant contestant, Sweepstakes sweepstakes)
        {
            manager.GetSweepstakes();
            manager.InsertSweepstakes(sweepstakes);
            contestant.GetContestantInfo();
            sweepstakes.RegisterContestant(contestant);
            sweepstakes.ContestantPickWinner();
            sweepstakes.PrintContestantInfo(contestant);
        }
        public void UseStackOrQueue()
        {
            string answer = UserInterface.GetStackOrQueue();
            if(answer == "stack")
            {
                manager = new SweepstakesStackManager();
            } else if( answer == "queue")
            {
                manager = new SweepstakesQueueManager();
            }
        }


    }
}
