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

        public void AddWin()
        {
            Wins += 1;
        }
        public void AddLoss()
        {
            Losses += 1;
        }
        public void AddDraw()
        {
            Draws += 1;
        }
        public string Record()
        {
            return $"{Wins}-{Losses}-{Draws}";
        }
    }
}
