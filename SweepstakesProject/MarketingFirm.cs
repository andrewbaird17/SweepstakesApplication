using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class MarketingFirm
    {
        //Member Variables (HAS A)
        private ISweepstakesManager _manager;
        //Constructor
        public MarketingFirm(ISweepstakesManager manager)
        {
            this._manager = manager;
        }
        //Member Methods (CAN DO)
        public void CreateSweepstake()
        {
            // Create new sweepstake
            Sweepstakes sweepstake = new Sweepstakes(UserInterface.GetUserInputFor("What is the name of this sweepstakes?"));
            //Add Sweepstake to manager
            _manager.InsertSweepstakes(sweepstake);
        }
        public Contestant RunSweepstake()
        {
            Sweepstakes sweepstakes = _manager.GetSweepstakes();
            Int32.TryParse(UserInterface.GetUserInputFor("How many contestants are allowed?"), out int contestantsMax);
            int contestants = 0;
            do
            {
                Contestant newContestant;
                sweepstakes.RegisterContestant(newContestant = new Contestant(UserInterface.GetUserInputFor("Enter First Name: "), UserInterface.GetUserInputFor("Enter Last Name:"), UserInterface.GetUserInputFor("Enter Email:")));
                sweepstakes.PrintContestantInfo(newContestant);
                contestants++;
            }
            while (contestantsMax != contestants);
            return sweepstakes.PickWinner();
        }
        public void EmailContestants()
        {
            // take the sweepstakes that was pulled off and notify contestants with a message of win or loss
            foreach (KeyValuePair<int,Contestant> contestant in sweepstakes.contestants)
            {
                if (contestant == winningContestant)
                {
                    contestant.Notify("You have won!");
                }
                else
                {
                    contestant.Notify("You did not win.");
                }
                
            }
        }
    }
}
