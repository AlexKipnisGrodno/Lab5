using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum GameState
{
    Start,
    End
}

namespace Lab5
{
 
    internal class Game
    {
        private int size;
        private string dataFile;
        private string logFile;
        private Player cat;
        private Player mouse;
        private GameState state;

        public Game(int size, string dataFile, string logFile) 
        { 
            this.size = size;
            this.dataFile = dataFile;
            this.logFile = logFile;
            cat = new Player("Cat");
            mouse = new Player("Mouse");
            state = GameState.Start;
        }

        public void Run()
        {
            while (state != GameState.End)
            {
                string line;
                char command; 
                using (StreamReader reader = new StreamReader(dataFile))
                {

                }
            }
        }

        private void DoMoveCommand(char command, int step)
        {
            switch(command)
            {
                case 'M': mouse.Move(step); break;
                case 'C': cat.Move(step); break;
            }
        }

        private void DoPrintCommand()
        {

        }

        private int GetDistance()
        {
            int distance = cat.location
           
        }

    }
}
