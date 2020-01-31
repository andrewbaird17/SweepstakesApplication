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
            ISweepstakesManager manager;
            switch (UserInterface.GetUserInputFor("Choose how to run your Sweepstakes: Stack or Queue").ToLower())
            {
                case "stack":
                    manager = new SweepstakesStackManager();
                    break;
                case "queue":
                    manager = new SweepstakesQueueManager();
                    break;
                default:
                    throw new Exception("Not a valid option");
            }
            MarketingFirm firm = new MarketingFirm(manager);
        }

    }
}
