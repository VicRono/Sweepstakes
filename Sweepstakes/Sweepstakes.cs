using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        
        public Dictionary<int, Contestant> dictionary;
        public UserInterface UI = new UserInterface();
        public Contestant contestant;
        public string name;
        public Random rnd = new Random();
        public string winner;
        public int winnerRegNumber;
        public int totalEntries;
        
        public Sweepstakes(string name)
        {
            dictionary = new Dictionary<int, Contestant>();
            this.name = name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            dictionary.Add(contestant.regNumber, contestant);
            totalEntries++;
        }

        public string PickWinner()
        {
            winnerRegNumber = rnd.Next(dictionary.Keys.Min(), dictionary.Keys.Max());
            Contestant sweepsWinner;
            sweepsWinner = dictionary[winnerRegNumber];
            winner = sweepsWinner.firstName + sweepsWinner.lastName;
            UI.PickWinnerDisplay(sweepsWinner);
            PrintContestantInfo(sweepsWinner);
            return winner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            UI.DisplayContestantInfo(contestant);
        }
    }
}
