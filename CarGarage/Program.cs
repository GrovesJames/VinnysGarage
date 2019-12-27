using System;

namespace CarGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inGame = true;
            while (inGame)
            {
                Game game = new Game();

                while (game.Exit == false)
                {
                    game.Enter();
                }
                inGame = false;
            }
        }
    }
}