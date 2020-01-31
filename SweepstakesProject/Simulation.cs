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
            Console.WriteLine("Choose how to run your Sweepstakes: Stack or Queue");
            switch (Console.ReadLine().ToLower())
            {
                case "stack":
                    MarketingFirm firmStack = new MarketingFirm();
                    break;
                case "queue":
                    MarketingFirm firmQueue = new MarketingFirm();
                    break;
                default:
                    throw new Exception("Not a valid option");
                    break;
            }
        }

    }
}
