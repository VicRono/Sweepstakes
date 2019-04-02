using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class UserInterface
    {
        public int RegistrationNumber;
        Random rnd = new Random();

        public string AssignSweepstakesName()
        {
            Console.WriteLine("Please Enter the Sweepstakes name:");
            string name = Console.ReadLine();
            return name;
        }
        public void AssignFirstName(Contestant contestant)
        {
            Console.WriteLine("Please enter your First Name");
            contestant.firstName = Console.ReadLine();
        }

        internal void AssingLastName(Contestant contestant)
        {
            Console.WriteLine("Please enter your First Name");
            contestant.lastName = Console.ReadLine();
        }

        internal void AssignEmail(Contestant contestant)
        {
            Console.WriteLine("Please enter your First Name");
            contestant.email = Console.ReadLine();
        }

        internal void AssignRegistrationNumber(Contestant contestant)
        {
            contestant.regNumber++;
        }

        public void DisplayContestantInfo(Contestant contestant)
        {
            
        }

        public void PickWinnerDisplay(Contestant contestant)
        {
            
        }
    }
}
