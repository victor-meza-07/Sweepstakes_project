using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        BackEnd back;
        public Simulation()
        {
            back = new BackEnd();
        }
        private ISweeptstakesManager GetModes() 
        {
            ISweeptstakesManager manager = null;
            int mode = GetManagerMode();
            if (mode == 1) {manager = new SweepstakesStackManager(); }
            else if (mode == 2) {manager = new SweeptakesQueueManager(); }

            return manager;
        }

        private int GetManagerMode() 
        {
            return back.GetDataModeInformation();
        } 
        public void CreateFirmWithManager() 
        {
            ISweeptstakesManager manager = GetModes();
            MarketingFirm marketingFirm = new MarketingFirm(manager);
        }
    }
}
