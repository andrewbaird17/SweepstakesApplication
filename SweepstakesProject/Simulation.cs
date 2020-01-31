using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Simulation
    {
        //Member Variables (HAS A)

        //Constructor

        //Member Methods (CAN DO)
        public void CreateMarketingFirmWithManager()
        {
            switch (UserInterface.GetUserInputFor("Choose how to run your Sweepstakes: Stack or Queue").ToLower())
            {
                case "stack":
                    SweepstakesStackManager stack = new SweepstakesStackManager();
                    MarketingFirm firmStack = new MarketingFirm(stack);
                    break;
                case "queue":
                    SweepstakesQueueManager queue = new SweepstakesQueueManager();
                    MarketingFirm firmQueue = new MarketingFirm(queue);
                    break;
                default:
                    throw new Exception("Not a valid option");
            }
        }

    }
}
