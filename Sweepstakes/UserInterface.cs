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

        public int NumberOfContestants()
        {
            try
            {
                Console.WriteLine("How many contestants will be playing Sweepstakes?");
                int response = Int32.Parse(Console.ReadLine());
                return response;
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a Valid Input");
                return NumberOfContestants();
            }
        }

        public void AssignFirstName(Contestant contestant)
        {
            Console.WriteLine("ENTRY NO. {0}", contestant.regNumber + 1);
            Console.WriteLine("Please enter the First Name of the contestant.");
            contestant.firstName = Console.ReadLine();
        }

        public void AssingLastName(Contestant contestant)
        {
            Console.WriteLine("Please enter your Last Name");
            contestant.lastName = Console.ReadLine();
        }

        public void AssignEmail(Contestant contestant)
        {
            Console.WriteLine("Please enter your Email:");
            contestant.email = Console.ReadLine();
        }

        public void AssignRegistrationNumber(Contestant contestant)
        {
            contestant.regNumber++;
        }

        public void DisplayContestantInfo(Contestant contestant)
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine($"Name: {contestant.firstName} {contestant.lastName}");
            info.AppendLine($"Email Address: {contestant.email}");
            info.AppendLine($"Registration Number:{ contestant.regNumber}");
            Console.WriteLine(info);
        }

        public void PickWinnerDisplay(Contestant contestant)
        {
            Console.WriteLine("Winner for this Sweepstake is: {0} {1}", contestant.firstName, contestant.lastName);
        }

        public void CloseGame()
        {
            Console.WriteLine("Thank You for playing!.");
        }

        public string ReRunSweepstakes()
        {
            Console.WriteLine("Do you want to run another Sweepstake?, Enter 'yes' or 'no");
            return Console.ReadLine().ToLower().Trim();
        }

    }
}
