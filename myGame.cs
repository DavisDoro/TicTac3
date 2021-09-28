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

        public void MakeMove(int Coordinate, string Symbol)
        {

            if (GameField.fieldValue[Coordinate - 1] == "X" || GameField.fieldValue[Coordinate - 1] == "O")
            {
                Console.WriteLine("Location {0} is already taken", Coordinate);
                Console.Write("Press Any Key to try again");
                Console.ReadLine();
            }
            else
            {
                GameField.fieldValue[Coordinate - 1] = Symbol;
            }

        }

        public string NextMoveBy() // check who goes next - P1 or P2.
        {

            foreach (string item in GameField.fieldValue)
            {
                if (item == "X")
                {

                    this.XinField++;
                }
                else if (item == "O")
                {

                    this.OinField++;
                }
            }
            if (XinField <= OinField)
            {
                this.Player = "Player1";
                return "X";
            }
            else
            {
                this.Player = "Player2";
                return "O";
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
        public bool IsWinner()  // ugly if wall for winner check
        {
            if (GameField.fieldValue[0] == GameField.fieldValue[1] && GameField.fieldValue[1] == GameField.fieldValue[2]) // first row
            {
                return true;
            }
            else if (GameField.fieldValue[3] == GameField.fieldValue[4] && GameField.fieldValue[4] == GameField.fieldValue[5]) //second row
            {
                return true;
            }
            else if (GameField.fieldValue[6] == GameField.fieldValue[7] && GameField.fieldValue[7] == GameField.fieldValue[8]) // third row
            {
                return true;
            }
            else if (GameField.fieldValue[0] == GameField.fieldValue[3] && GameField.fieldValue[3] == GameField.fieldValue[6]) // first column
            {
                return true;
            }
            else if (GameField.fieldValue[1] == GameField.fieldValue[4] && GameField.fieldValue[4] == GameField.fieldValue[7]) // second column
            {
                return true;
            }
            else if (GameField.fieldValue[2] == GameField.fieldValue[5] && GameField.fieldValue[5] == GameField.fieldValue[8]) // third column
            {
                return true;
            }
            else if (GameField.fieldValue[0] == GameField.fieldValue[4] && GameField.fieldValue[4] == GameField.fieldValue[8])// diagonal one
            {
                return true;
            }
            else if (GameField.fieldValue[2] == GameField.fieldValue[4] && GameField.fieldValue[4] == GameField.fieldValue[6]) // diagonal two
            {
                return true;
            }
            return false;


        }

    }
}
