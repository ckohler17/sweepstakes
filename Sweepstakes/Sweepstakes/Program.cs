using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            MarketingFirm marketingFirm;
            string answer = UserInterface.GetStackOrQueue();
            if (answer == "stack")
            {
                marketingFirm = new MarketingFirm(new SweepstakesStackManager());
            }
            else if (answer == "queue")
            {
                marketingFirm = new MarketingFirm(new SweepstakesQueueManager());
            }
        }
    }
}
