using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepStakes
    {
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name { get { return name; } }
        public SweepStakes()
        {
            contestants = new Dictionary<int, Contestant>();
        }

        public void Sweepstakes(string name) { }
        public void RegistrContestant(Contestant contestant) { }
        public Contestant PickWinner() 
        {
            Contestant winner = new Contestant();
            return winner;
        }
        public void PrintContestantInfo(Contestant contestant) 
        {

        }




    }
}
