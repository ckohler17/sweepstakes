using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        public string name;
        public Dictionary<int, Contestant> contestants;
        
        public Sweepstakes(string name)
        {
            this.name = name;
            Dictionary < int, Contestant> contestants = new Dictionary<int, Contestant>();
        }


        void RegisterContestant(Contestant contestant)
        {            
                contestants.Add(contestant.registrationNum, contestant);
            
        }
        ContestantPickWinner();

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
