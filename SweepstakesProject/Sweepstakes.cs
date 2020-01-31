using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Sweepstakes
    {   // USE DICTIONARY DATA STRUCTURE

        //Member Variables (HAS A)
        string name;
        Contestant contestant;

        //Constructor
        Sweepstakes(string name)
        {
            this.name = name;
        }

        //Member Methods (CAN DO)
        void RegisterContestant(Contestant contestant)
        {
            // Use UserInterface to get info to pass to Contestant Class
            
            contestant = new Contestant();
        }
        void PrintContestantInfo(Contestant contestant)
        {

        }

        // Below should be Contestant PickWinner()
        void PickWinner()
        {
           
        }

    }
}
