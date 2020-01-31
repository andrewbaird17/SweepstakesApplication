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
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface.GetUserInputFor("What is the name of this sweepstakes?"));
        }

    }
}
