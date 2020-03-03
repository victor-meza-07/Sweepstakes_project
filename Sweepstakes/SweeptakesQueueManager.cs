using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweeptakesQueueManager : ISweeptstakesManager
    {
        private Queue<SweepStakes> queue;
        
        public SweeptakesQueueManager()
        {
            queue = new Queue<SweepStakes>();
        }

        

        public void InsertSweepStakes(SweepStakes sweepStakes)
        {
            queue.Enqueue(sweepStakes);
        }

        public SweepStakes GetSweepStakes()
        {
            return queue.Dequeue();
        }
    }
}
