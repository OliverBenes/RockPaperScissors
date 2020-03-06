using RockPaperScissors.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissors.Service
{
    public class RpsLogic
    {
        private readonly Random random;

        public RpsLogic(Random random)
        {
            this.random = random;
        }

        public Rps userData { get; set; }

        public void GameRound(RpsMode userChoice)
        {
            bool? isWinner = null;
            RpsMode aiChoice = (RpsMode)random.Next(1, 4);

            if (aiChoice == RpsMode.Rock && userChoice == RpsMode.Paper ||
                aiChoice == RpsMode.Paper && userChoice == RpsMode.Scissors ||
                aiChoice == RpsMode.Scissors && userChoice == RpsMode.Rock)
                userData.WinCounter++;
            else if (aiChoice == userChoice)
                userData.DrawCounter++;
            else userData.LossCounter++;

        }
    }
}
