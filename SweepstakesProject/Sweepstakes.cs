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
        public void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNum = (contestants.Count) + 1;
            contestants.Add( contestant.registrationNum, contestant);
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"First Name: {contestant.firstName}" +
                $"Last Name: {contestant.lastName}" +
                $"Email: {contestant.email}" +
                $"Registration Number: {contestant.registrationNum}");
        }
        public Contestant PickWinner()
        {
            Random random = new Random();
            Contestant randomWinner;
            // Use Random to select a random number from the length of the dictionary contestants
            int randNum = random.Next(0, (contestants.Count) + 1);
            randomWinner = contestants[randNum];
            return randomWinner;
        }
        public void EmailContestants(Contestant winner)
        {
            // take the sweepstakes that was pulled off and notify contestants with a message of win or loss
            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {
                if (contestant.Value == winner)
                {
                    contestant.Value.Notify($"Congratulations!!! {contestant.Value.firstName} {contestant.Value.lastName} You have won!!!" +
                        $" You will be contacted with additional details in an email.");
                }
                else
                {
                    contestant.Value.Notify($"{contestant.Value.firstName} {contestant.Value.lastName} you did not win. Better luck next time!");
                }
            }
        }
    }
}
