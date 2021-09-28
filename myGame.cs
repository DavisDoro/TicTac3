using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac3
{
    public class myGame // spēles noteikumi
    {
        public string Symbol { get; set; }
        public int Coordinate { get; set; }
        public string Player { get; set; }
        public int XinField { get; set; }
        public int OinField { get; set; }
        //string player = "Player1";
        public void MakeMove(int Coordinate, string Symbol)
        {
            
            if (GameField.fieldValue[Coordinate - 1] == "X" || GameField.fieldValue[Coordinate - 1] == "O")
            {
                Console.WriteLine("Location {0} is not already taken", Coordinate);
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
        public bool IsGameOver()
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
        public void IsWinner()
        {

        }
        //public bool Validate(string input)
        //{
        //    if (int.TryParse(input, out int inputInt) && LegalMove(inputInt))
        //        {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public bool LegalMove(int inputInt)
        //{
        //    if (GameField.fieldValue[inputInt -1] == "X" || GameField.fieldValue[inputInt -1] == "O")
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

    }

}
