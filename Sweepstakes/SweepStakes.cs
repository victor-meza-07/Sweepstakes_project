﻿using System;
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
        private int registrationNumberCount;
        public string Name { get { return name; } }
        public int RegistrationNumber { get { return registrationNumberCount; } }
        public SweepStakes()
        {
            contestants = new Dictionary<int, Contestant>();
            registrationNumberCount = 0;
        }

        public void Sweepstakes(string name) 
        {
            this.name = name;
        }
        public void RegistrContestant(Contestant contestant) 
        {
            registrationNumberCount++;
            contestant.SetContestantRegNumber(registrationNumberCount);
            contestants.Add(contestant.RegistrationNumber, contestant);
        }
        public Contestant PickWinner() 
        {
            Contestant winner = new Contestant();
            Random random = new Random();

            contestants.TryGetValue(random.Next(registrationNumberCount), out winner);
            return winner;
        }
        public void PrintContestantInfo(Contestant contestant) 
        {
            Console.WriteLine(" ");
            Console.WriteLine(contestant.FirstName + " " + contestant.LastName);
            Console.WriteLine(contestant.Email);
            Console.WriteLine(contestant.RegistrationNumber); 
        }
        public Contestant GetContestant(int key) 
        {
            Contestant contestant = new Contestant();
            contestants.TryGetValue(key, out contestant);
            return contestant;
        }




    }
}
