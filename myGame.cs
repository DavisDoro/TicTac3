using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac3
{
    public class myGame // game rules
    {
        public string Symbol { get; set; }
        public int Coordinate { get; set; }
        public string Player { get; set; }
        public int XinField { get; set; }
        public int OinField { get; set; }
        GameField tictoc = new GameField();
        public void MakeMove(int Coordinate, GameField tictac)
        {

            if (tictac.fieldValue[Coordinate - 1] == "X" || tictac.fieldValue[Coordinate - 1] == "O")
            {
                Console.WriteLine("Location {0} is already taken", Coordinate);
                Console.Write("Press Any Key to try again");
                Console.ReadLine();
            }
            else
            {
                tictac.fieldValue[Coordinate - 1] = Symbol;
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
        public bool IsGameOver() // check if all fields are full
        {


            if ((XinField + OinField) == 9)
            {
                return true;
            }
            else
            {
                return false;
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
        public void Reset(GameField tictac) // reset field values
        {
            int setTo = 0;
            for (int i = 0; i < tictac.fieldValue.Length; i++)
            {
                setTo++;
                tictoc.fieldValue[i] = setTo.ToString();
            }
        }
        static void NewGame(string input)
        {
            GameField tictac = new GameField();
            if (input.Equals("y"))
            {
                tictac.Reset();

                Console.Clear();
                // and print field
            }
            else
            {
                Environment.Exit(0);
            }
        }

    }
}
