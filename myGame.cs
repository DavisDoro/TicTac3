using System;

namespace TicTac3
{
    
    public class myGame // game rules
    {
        public myGame(GameField tictac)
        {
            this.Tictac = tictac;
        }
        public string Symbol { get; set; }
        public string Player { get; set; }
        public GameField Tictac { get; }
        public int MoveCounter { get; set; }

        public void MakeMove(int Coordinate, GameField tictac)   // Checks and performs next player move
        {
            if (tictac.fieldValue[Coordinate - 1] == "X" || tictac.fieldValue[Coordinate - 1] == "O")
            {
                Console.WriteLine("Location {0} is already taken", Coordinate);
                Console.Write("Press Any Key to try again");
                Console.ReadKey();
            }
            else
            {
                tictac.fieldValue[Coordinate - 1] = Symbol;
                MoveCounter++;  // counts total legit player moves
            }
        }
        public void ChangePlayer()
        {
            if (Player == "1")
            {
                Player = "2";
                Symbol = "O";
            }
            else
            {
                Player = "1";
                Symbol = "X";
            }
        }
        public bool IsWinner(GameField tictac)  // ugly if wall for winner check
        {
            if (tictac.fieldValue[0] == tictac.fieldValue[1] && tictac.fieldValue[1] == tictac.fieldValue[2]) // first row
            {
                return true;
            }
            else if (tictac.fieldValue[3] == tictac.fieldValue[4] && tictac.fieldValue[4] == tictac.fieldValue[5]) //second row
            {
                return true;
            }
            else if (tictac.fieldValue[6] == tictac.fieldValue[7] && tictac.fieldValue[7] == tictac.fieldValue[8]) // third row
            {
                return true;
            }
            else if (tictac.fieldValue[0] == tictac.fieldValue[3] && tictac.fieldValue[3] == tictac.fieldValue[6]) // first column
            {
                return true;
            }
            else if (tictac.fieldValue[1] == tictac.fieldValue[4] && tictac.fieldValue[4] == tictac.fieldValue[7]) // second column
            {
                return true;
            }
            else if (tictac.fieldValue[2] == tictac.fieldValue[5] && tictac.fieldValue[5] == tictac.fieldValue[8]) // third column
            {
                return true;
            }
            else if (tictac.fieldValue[0] == tictac.fieldValue[4] && tictac.fieldValue[4] == tictac.fieldValue[8])// diagonal one
            {
                return true;
            }
            else if (tictac.fieldValue[2] == tictac.fieldValue[4] && tictac.fieldValue[4] == tictac.fieldValue[6]) // diagonal two
            {
                return true;
            }
            return false;
        }
        public void NewGame(string input, GameField tictac) // asks player and resets game or quits
        {
            if (input.Equals("y"))
            {
                MoveCounter = 0;
                tictac.Reset();   
                Console.Clear();
                tictac.Print();
            }
            else
            {
                Environment.Exit(0);
            }
        }

    }
}
