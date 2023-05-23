using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum State
{
    Winner,
    Looser,
    Playing,
    NotInGame
}

namespace Lab5
{
    internal class Player
    {
        private string name;
        private int location;
        private State state = State.NotInGame;
        private int distanceTraveled = 0;

        public Player(string name)
        {
            this.name = name;
            this.location = -1;
        }

        public void Move(int x)
        {

        }
    }
}
