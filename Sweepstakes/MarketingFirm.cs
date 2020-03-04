using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        private ISweeptstakesManager _manager;
        public MarketingFirm(ISweeptstakesManager manager) // Constructor Injection
        {
            _manager = manager;
        }
        public void CreateSweepStake()
        {
            SweepStakes sweepStakes = new SweepStakes();
            string name = null;
            name = UserInterface.DisplaySweepstakeName(name);
            sweepStakes.Sweepstakes(name);
            _manager.InsertSweepStakes(sweepStakes);
        }
    }
}
