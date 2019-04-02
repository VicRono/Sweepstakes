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

        public Sweepstakes GetSweepstake()
        {
            return queueSweep.Dequeue();
        }

        public void InsertSweepstake(Sweepstakes sweepstakes)
        {
            queueSweep.Enqueue(sweepstakes);
        }
    }
}
