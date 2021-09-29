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
            myGame move = new myGame();
            move.Player = new System.Random().Next(1, 2).ToString(); // Random player 1 move

            move.NewGame(tictac, "y"); //print first game screen

            do                          // main game loop
            {
                Console.Clear();
                

                move.ChangePlayer(); // asigns player number and player symbol

                if (move.IsGameOver())          //checks if game is over as draw
                {
                    inputString = "reset";     //allowes smooth transition to next round
                    Console.Write("GAME OVER, start new game? y/n ");
                    string startNewGame = Console.ReadLine();
                    NewGame(move, startNewGame);     //resets game
                }
                else
                {
                    Console.Write($"What is your next move Player{move.Player}: ");  // prints player number 
                    inputString = Console.ReadLine();
                }

                if (inputString.Equals("reset"))             // This allowes program to skip Validate() method and start new round
                {
                    Console.WriteLine("This wont be displayed anyway");
                }
                else if (Validate(inputString))
                {
                    move.MakeMove(input);
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }

                if (move.IsWinner())  // if there is a winner print congratulation message
                {
                    Console.Clear();
                    tictac.Print();
                    Congratulate(move);
                }

            } while (!move.IsWinner());         // if winner decided game stops
            
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


        
        static void Congratulate(myGame move)
        {

            Console.WriteLine($"\r\nCongratulations Player{move.Player}, you WON!");
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
