using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            while (!game.GameOver){
                game.PlayerMove();
            }
        }
    }
}
