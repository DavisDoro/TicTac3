using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac3
{
    class GameField
    {
        public static string[] fieldValue = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        //public int Player1Id { get; set; }
        //public int Player2Id { get; set; }
        //public GameField(int Id1, int Id2)
        //{
        //    this.Player1Id = Id1;
        //    this.Player2Id = Id2;
        //}
        public void Print()
        {
            Console.WriteLine("      {0} | {1} | {2} ", fieldValue[0], fieldValue[1], fieldValue[2]);
            Console.WriteLine("     ---+---+---");
            Console.WriteLine("      {0} | {1} | {2} ", fieldValue[3], fieldValue[4], fieldValue[5]);
            Console.WriteLine("     ---+---+---");
            Console.WriteLine("      {0} | {1} | {2} ", fieldValue[6], fieldValue[7], fieldValue[8]);
            Console.WriteLine("     ¯¯¯¯¯¯¯¯¯¯¯");
        }
        public string NextMoveBy() // check who goes next - P1 or P2.
        {
            int XinField = 0;
            int YinField = 0;
            foreach (string item in fieldValue)
            {
                if (item == "X")
                {
                    XinField++;
                }
                else if (item == "O")
                {
                    YinField++;
                }
            }
            if (XinField <= YinField)
            {
                return "X";
            }
            return "O";
        }
        public void MakeMove() // perform player move 
        {
            int position;
            if (int.TryParse(Console.ReadLine(), out position) && position > 0 && position < 10)
            {
                fieldValue[position -1] = NextMoveBy();
            }
            else
            {
                Console.WriteLine("Incorrect input, try again");
                MakeMove();
            }
            
        }


    }
}
