using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Contestant : INotify
    {
        //Member Variables (HAS A)
        public string firstName;
        public string lastName;
        public string email;
        public int registrationNum;

        //Constructor
        public Contestant(string firstName, string lastName, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }
        //Member Methods (CAN DO)

        public void Notify()
        {
            Console.WriteLine("Thank you for entering! A winner has been chosen. You did not win");
        }
    }
}
