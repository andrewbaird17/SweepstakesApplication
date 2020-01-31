using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        //Member Variables (HAS A)
        private Queue<Sweepstakes> queue;

        //Constructor
        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }

        //Member Methods (CAN DO)
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return queue.Dequeue();
        }
    }
}
