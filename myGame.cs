using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac3
{
    public class myGame
    {
        public string Symbol { get; set; }
        public int Coordinate { get; set; }
        //public myGame(int coord)
        //{
        //    this.Coordinate = coord;
        //}

        public void MakeMove(int Coordinate, string Symbol)
        {
         GameField.fieldValue[Coordinate - 1] = Symbol;
        }

        public string NextMoveBy() // check who goes next - P1 or P2.
        {
            int XinField = 0;
            int OinField = 0;
            foreach (string item in GameField.fieldValue)
            {
                if (item == "X")
                {
                    XinField++;
                }
                else if (item == "O")
                {
                    OinField++;
                }
            }
            if (XinField <= OinField)
            {
                return "X";
            }
            return "O";
        }
        public bool Validate(string input)
        {
            if (int.TryParse(input, out int inputInt))
                {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
