using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class ChooseManager
    {
        static public ISweepstakesManager PickManager()
        {
            ISweepstakesManager manager;
            Console.WriteLine("Choose what SweepstakesManager\n 1.)Stack\n 2.)Queue");
            int.TryParse(Console.ReadLine(), out int input);

            switch (input)
            {
                case 1:
                    manager = new SweepstakesStackManager();
                    break;
                case 2:
                    manager = new SweepstakesQueueManager();
                    break;
                default:
                    manager = PickManager();
                    break;
            }
            return manager;
        }
    }
}
