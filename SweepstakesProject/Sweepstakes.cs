using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Sweepstakes
    {
        //Member Variables (HAS A)
        // USE DICTIONARY DATA STRUCTURE
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        Contestant contestant;

        //Constructor
        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        //Member Methods (CAN DO)
        void RegisterContestant(Contestant contestant)
        {
            // Use UserInterface to get info to pass to Contestant Class
            contestant.registrationNum = (contestants.Count) + 1;
            contestants.Add( , contestant);
        }
        void PrintContestantInfo(Contestant contestant)
        {

        }
        Contestant PickWinner()
        {
            Random random = new Random();
            Contestant randomWinner;
            // Use Random to select a random number from the length of the dictionary contestants
            int randNum = random.Next(0, (contestants.Count) + 1);
            randomWinner = contestants[randNum];
            return randomWinner;
        }
    }
}
