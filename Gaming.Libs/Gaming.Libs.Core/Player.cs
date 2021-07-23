using Gaming.Libs.Core.Enums;
using System;

namespace Gaming.Libs.Core
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
            Wins = 0;
            Losses = 0;
            Draws = 0;
        }

        public string Name { get; private set; }
        private int Wins { get; set; }
        private int Losses { get; set; }
        private int Draws { get; set; }

        public void UpdateName(string name)
        {
            Name = name;
        }

        public void IncrementFromOutcome(GameOutcome outcome)
        {
            switch (outcome)
            {
                case GameOutcome.Win: AddWin(); break;
                case GameOutcome.Lose: AddLoss(); break;
                case GameOutcome.Draw: AddDraw(); break;
            }
        }
        public string Record => $"{Wins}-{Losses}-{Draws}";

        #region private methods
        private void AddWin()
        {
            Wins += 1;
        }
        private void AddLoss()
        {
            Losses += 1;
        }
        private void AddDraw()
        {
            Draws += 1;
        }
        #endregion
    }
}
