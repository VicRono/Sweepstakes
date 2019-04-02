using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string email;
        public int regNumber;

        public Contestant(string firstName, string lastName, string email, int regNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.regNumber = regNumber;
        }

    }
}
