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
        public Dictionary<string, string> contestants;
        
        public Sweepstakes(string name)
        {
            this.name = name;
            Dictionary < string, string> contestants = new Dictionary<string, string>;
        }


        void RegisterContestant(Contestant contestant)
        {
            for (int i = 0; i < contestant. i++) {
                contestants.Add(i, contestant[i]);
            }
        }
        ContestantPickWinner();

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
