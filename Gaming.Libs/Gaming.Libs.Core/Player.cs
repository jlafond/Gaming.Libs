using System;

namespace Gaming.Libs.Core
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int Wins { get; set; }
        public int Lose { get; set; }
        public int Draw { get; set; }
    }
}
