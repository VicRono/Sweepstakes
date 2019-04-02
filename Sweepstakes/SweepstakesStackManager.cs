using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> stackSweep = new Stack<Sweepstakes>();

        public Sweepstakes GetSweepstakes()
        {
            return stackSweep.Pop();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stackSweep.Push(sweepstakes);
        }
    }
}
