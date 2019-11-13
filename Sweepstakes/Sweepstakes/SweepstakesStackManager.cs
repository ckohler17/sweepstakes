using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> stack;
        public SweepstakesStackManager()
        {
            Stack<Sweepstakes> stack = new Stack<Sweepstakes>();
        }
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes item = stack.Pop();
            return item;            
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {            
            stack.Push(sweepstakes);
        }

    }
}
