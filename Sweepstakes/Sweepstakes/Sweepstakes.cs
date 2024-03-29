﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        public string name;
        public Dictionary<int, Contestant> contestants;
        
        public Sweepstakes(string namePass)
        {
            name = namePass;
            contestants = new Dictionary<int, Contestant>();
        }


        public void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNum = contestants.Count;    
            contestants.Add(contestant.registrationNum, contestant);            
        }
        public Contestant ContestantPickWinner()
        {
            Random random = new Random();
            int winningNumber = random.Next(0, contestants.Count+1);
            Contestant winningContestant = contestants[winningNumber];
            return winningContestant;

        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.firstName + "," + contestant.lastName + "," + contestant.email + "," + contestant.registrationNum); );
        }
    }
}
