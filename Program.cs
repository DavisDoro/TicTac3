using System;

namespace TicTac3
{
    public class Program
    {
        public static string[] fieldValue;
        static int input = 0;
        static string symbol;
        static void Main(string[] args)
        {
            string inputString;
            GameField tictac = new GameField();
            do
            {
                Console.Clear();
                tictac.Print(); // void                           
                
                Console.Write("What is your next move: ");
                inputString = Console.ReadLine();
                myGame move = new myGame();

                symbol = move.NextMoveBy();
                if (move.Validate(inputString))
                {
                    input = int.Parse(inputString);
                    move.MakeMove(input, symbol);
                }
            } while (!Winner.WeHaveWinner());
            Console.WriteLine("Hello World!");
        }
    }
}
