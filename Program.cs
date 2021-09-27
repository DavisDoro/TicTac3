using System;

namespace TicTac3
{
    public class Program
    {
        public static string[] fieldValue;
        static void Main(string[] args)
        {
            GameField tictac = new GameField();
            do
            {
                tictac.Print(); // void                           
                tictac.MakeMove(); //void

            } while (!Winner.WeHaveWinner());

            //CheckForWinner(string[])
            //AnounceWinner(int playerID)

            Console.WriteLine("Hello World!");
        }
    }
}
