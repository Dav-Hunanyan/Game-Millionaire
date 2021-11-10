using System;

namespace Millionaire
{
    class GameRules
    {
        public static void Gamerules()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("              Who wants to be a millionaire\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("       Answer questions right and you will win million");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("If you don't know right answer you can use the help provided to you");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("There are 10 questions\n");
            for (int j = 0; j < 10; j++)
            {
                if (j == 3 || j == 6)
                {
                    Console.WriteLine((j + 1) + " question - " + Money_.MoneyWin(j + 1) + "$  Inviolable  ");
                }
                else
                {
                    Console.WriteLine((j + 1) + " question - " + Money_.MoneyWin(j + 1) + "$");
                }
            }

            Console.WriteLine("\nEnter to start the game..");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
