using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        public Sweepstakes sweepstakes;
        public string sweepstakesName;
        public ISweepstakesManager Manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.Manager = manager;
            sweepstakes = new Sweepstakes(sweepstakesName);
         
        }
        public void RunSweepstakes()
        {
            CreateSweepstakes();
            CreateContestant();
        }
        public void CreateSweepstakes()
        {
            sweepstakesName = sweepstakes.UI.AssignSweepstakesName();
            sweepstakes = new Sweepstakes(sweepstakesName);
        }
        public void CreateContestant()
        {
            for (int i = 0; i < 3; i++)
            {
                sweepstakes.UI.AssignFirstName(sweepstakes.contestant);
                sweepstakes.UI.AssingLastName(sweepstakes.contestant);
                sweepstakes.UI.AssignEmail(sweepstakes.contestant);
                sweepstakes.UI.AssignRegistrationNumber(sweepstakes.contestant);
                sweepstakes.RegisterContestant(sweepstakes.contestant);
            }
        }

    }
}
