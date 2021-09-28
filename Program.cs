using System;

namespace TicTac3
{
    public class Program
    {
        public static string[] fieldValue;
        static int input = 0;
        static string symbol;
        static string inputString;
        static void Main(string[] args)
        {
            //string inputString;
            //GameField tictac = new GameField();
            //myGame move = new myGame();
            //Play();


            do
            {
                Play();

            } while (!Winner.WeHaveWinner());

        }

            static bool Validate(string inputStr) // Pārbauda vai izvēlētais lauciņš jau nav aizņemts
             {
            if (int.TryParse(inputStr, out input) && (input >= 1 && input <= 9))
            {
                return true;
            }
            else
            {
                Console.Write("Incorrect input, press Any Key to try again");
                Console.ReadKey();
                return false;
            }
        }
        static void NewGame(myGame move, GameField tictac)
        {
            Console.WriteLine("GAME OVER");
            Console.Write("Start new game? y/n ");
            string newGame = Console.ReadLine();
            if (newGame.Equals("y"))
            {

                tictac.Reset();
                Console.Clear();
                tictac.Print();
                //symbol = move.NextMoveBy();
            }
            else
            {
                Environment.Exit(0);
            }
        }
        static void Play()
        {
            GameField tictac = new GameField();
            myGame move = new myGame();
            Console.Clear();
            tictac.Print();
            symbol = move.NextMoveBy();
            if (move.IsGameOver())
            {
                NewGame(move, tictac);
            }
            else
            {
                Console.Write($"What is your next move {move.Player}: ");
                inputString = Console.ReadLine();
            }
            if (Validate(inputString))
            {
                move.MakeMove(input, symbol);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }


    }
}
