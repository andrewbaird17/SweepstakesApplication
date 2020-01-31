using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Contestant
    {
        //Member Variables (HAS A)
        public string firstName;
        public string lastName;
        public string email;
        public int registrationNum;

        //Constructor
        public Contestant(string firstName, string lastName, string email, int registrationNum)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.registrationNum = registrationNum;
        }
        //Member Methods (CAN DO)


    }
}
