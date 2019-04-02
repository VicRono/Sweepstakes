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
            ISweepstakesManager manager;
            manager = ChooseManager.PickManager();
            MarketingFirm marketfirm = new MarketingFirm(manager);
            marketfirm.StartSweepstakes("yes");
            Console.ReadLine();
        }
    }
}
