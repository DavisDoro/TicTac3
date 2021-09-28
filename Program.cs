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
            GameField tictac = new GameField();
            myGame move = new myGame();

            do                          // main game loop
            {
                Play();

            } while (!move.IsWinner());         // if winner decided game stops
            
        }
        static void Play()                      // main game method
        {
            GameField tictac = new GameField();
            myGame move = new myGame();
            Console.Clear();
            tictac.Print();
            symbol = move.NextMoveBy();    // asigns next move Symbol

            if (move.IsGameOver())          //checks if game is over as draw
            {
                inputString = "reset";     //allowes smooth transition to next round
                NewGame(move, tictac);     //asks and resets game
            }
            else
            {
                Console.Write($"What is your next move {move.Player}: ");  // prints player number 
                inputString = Console.ReadLine();
            }

            if (inputString.Equals("reset"))             // This allowes program to skip Validate() method and start new round
            {
                Console.WriteLine("This wont be displayed anyway");
            }
            else if (Validate(inputString))
            {
                move.MakeMove(input, symbol);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }

            if (move.IsWinner())  // if there is a winner print congratulation message
            {
                Console.Clear();
                tictac.Print();
                Congratulate(move, tictac);
            }

        }
        static bool Validate(string inputStr)       // Input check is it between 1 and 9
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
            }
            else
            {
                Environment.Exit(0);
            }
        }
        
        static void Congratulate(myGame move, GameField tictac)
        {

            Console.WriteLine($"\r\nCongratulations {move.Player}, you WON!");

            Console.Write("Start new game? y/n ");
            string newGame = Console.ReadLine();
            if (newGame.Equals("y"))
            {
                tictac.Reset();
                Console.Clear();
            }
            else
            {
                Environment.Exit(0);
            }

        }


    }
}
