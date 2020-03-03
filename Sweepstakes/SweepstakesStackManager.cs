using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweeptstakesManager
    {
        private Stack<SweepStakes> stack;
        public SweepstakesStackManager()
        {
            stack = new Stack<SweepStakes>();
        }

        public SweepStakes GetSweepStakes()
        {
            return stack.Pop();
        }

        public void InsertSweepStakes(SweepStakes sweepStakes)
        {
            stack.Push(sweepStakes);
        }
    }
}
