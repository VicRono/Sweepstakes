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
        public ISweepstakesManager manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
            sweepstakes = new Sweepstakes(sweepstakesName);
         
        }

        public void LaunchApp(string input)
        {
            if (input.ToLower() == "yes")
            {
                manager.InsertSweepstakes(sweepstakes);
                RunSweepstakes();
                LaunchApp(sweepstakes.UI.ReRunSweepstakes());
            }
            else
            {
                
                sweepstakes.PickWinner();
                sweepstakes.UI.CloseGame();
                return;
            }
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
