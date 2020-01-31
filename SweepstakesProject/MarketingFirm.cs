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
            //Run Sweepstake
            RunSweepstake(sweepstake);
            //GetSweepstake
            do
            {
                _manager.GetSweepstakes();
            }
            while (sweepstake.Name == UserInterface.GetUserInputFor("Retrieve Which Sweepstake?"));
            
            // Notify Contestants that a winner was picked 
        }
        public Contestant RunSweepstake(Sweepstakes sweepstakes)
        {
            do
            {
                Contestant newContestant;
                sweepstakes.RegisterContestant(newContestant = new Contestant(UserInterface.GetUserInputFor("Enter First Name: "), UserInterface.GetUserInputFor("Enter Last Name:"), UserInterface.GetUserInputFor("Enter Email:")));
                sweepstakes.PrintContestantInfo(newContestant);
            }
            while (UserInterface.GetUserInputFor("Keep sweepstakes open?") != "no");
            return sweepstakes.PickWinner();
        }

    }
}
