using Gaming.Libs.Core.Enums;
using Gaming.Libs.RockPaperScissors.Enums;
using System;

namespace Gaming.Libs.RockPaperScissors
{
    public static class RockPaperScissors
    {
        /// <summary>
        /// Main gameplay method of Rock Paper Scissors game
        /// </summary>
        /// <param name="playerChoice"></param>
        /// <returns>The outcome (win/lose/draw) and displayable text with both player and computers moves and outcome</returns>
        public static (GameOutcome, string) Shoot(Choice playerChoice)
        {
            //Computer makes decision before viewing player choice
            var computerChoice = GetComputerChoice();

            //Check outcome
            var outcome = DetermineOutcome(playerChoice, computerChoice);

            return (outcome, $"Player threw: {playerChoice}.\nCPU threw: {computerChoice}.\n Outcome is {outcome}");
        }


        /// <summary>
        /// Gets the choice by the computer player on rock, paper, or scissors
        /// </summary>
        /// <returns></returns>
        private static Choice GetComputerChoice()
        {
            return (Choice)(new Random().Next(1, 4));
        }

        private static GameOutcome DetermineOutcome(Choice player, Choice cpu)
        {
            if(player == cpu)
            {
                return GameOutcome.Draw;
            }
            switch (player)
            {
                case Choice.Rock: return cpu == Choice.Scissors ? GameOutcome.Win : GameOutcome.Lose;
                case Choice.Paper: return cpu == Choice.Rock ? GameOutcome.Win : GameOutcome.Lose;
                case Choice.Scissors: return cpu == Choice.Paper? GameOutcome.Win : GameOutcome.Lose;
            }
            return GameOutcome.Draw;
        }
    }
}
