using System;

namespace TicTac3
{
    public class Program
    {
        public static string[] fieldValue;
        static int input = 0;
        static string inputString;
        static void Main(string[] args)
        {
            GameField tictac = new GameField();
            myGame move = new myGame(tictac);

            move.Player = new System.Random().Next(1, 3).ToString(); // Random player for first move
            move.ChangePlayer(); // asigns player symbol after Random() generats who goes first
            move.NewGame("y", tictac); //print first game screen

            do                          // main game loop
            {
                tictac.Print();
                if (move.MoveCounter == 9)          //checks if game is over as draw
                {
                    inputString = "reset";     //allowes smooth transition to next round
                    Console.Write("GAME OVER, start new game? y/n ");
                    string startNewGame = Console.ReadLine();
                    move.NewGame(startNewGame, tictac);     //resets game
                }

                Console.Write($"What is your next move Player{move.Player}({move.Symbol}): ");  // prints player number 
                inputString = Console.ReadLine();

                if (inputString.Equals("reset"))             // This allowes program to skip Validate() method and start new round
                {
                    Console.WriteLine("This wont be displayed anyway");
                }
                else if (Validate(inputString))
                {
                    move.MakeMove(input, tictac);
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }

                if (move.IsWinner(tictac))  // if there is a winner print congratulation message
                {
                    tictac.Print();
                    Congratulate(move, tictac);
                }
                move.ChangePlayer(); // asigns player number and player symbol

            } while (!move.IsWinner(tictac));         // if winner decided game stops

        }  // [MAIN ENDS]

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

        static void Congratulate(myGame move, GameField tictac)
        {
            Console.WriteLine($"\r\nCongratulations Player{move.Player}, you WON!");
            Console.Write("Start new game? y/n ");
            string newGame = Console.ReadLine();
            if (newGame.Equals("y"))
            {
                move.NewGame("y", tictac);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
