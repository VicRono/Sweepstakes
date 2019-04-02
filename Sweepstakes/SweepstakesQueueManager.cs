using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> queueSweep = new Queue<Sweepstakes>();

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queueSweep.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return queueSweep.Dequeue();
        }
    }
}
