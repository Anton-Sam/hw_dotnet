using System;

namespace HW03.Game
{
    class Program
    {
        static void Main(string[] args)
        {
            GameStart();
        }

        private static void GameStart()
        {
            Console.WriteLine("Welcome to game!\nUse W,A,S,D for movement.\nUse q for exit\nGood luck!");
            ConsoleKeyInfo input;
            do
            {
                input = Console.ReadKey(true);
                switch (input.Key.ToString())
                {
                    case "W":
                        Console.WriteLine("Step forward");
                        break;
                    case "S":
                        Console.WriteLine("Step back");
                        break;
                    case "A":
                        Console.WriteLine("Step left");
                        break;
                    case "D":
                        Console.WriteLine("Step right");
                        break;
                    case "Q":
                        Console.WriteLine("Game over!");
                        return;
                    default:
                        Console.WriteLine("Can't move");
                        break;
                }
            }
            while (true);
        }
    }
}
