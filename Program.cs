using Lab5;

namespace Lab5
{
    enum StateOfGame
    {
        Start,
        End
    }

    internal class Program
    {
        static void Main()
        {
            string dataFile = "1.ChaseData.txt";
            string logFile = "1.PursuitLog.txt";

            Game game = new Game(dataFile, logFile);
            game.Run();
        }
    }
}