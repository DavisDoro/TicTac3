using System;

namespace TicTac3
{
    public class GameField // game field and field manipulations
    {
        public string[] fieldValue = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public void Print()
        {
            Console.Clear();
            Console.WriteLine("      {0} | {1} | {2} ", fieldValue[0], fieldValue[1], fieldValue[2]);
            Console.WriteLine("     ---+---+---");
            Console.WriteLine("      {0} | {1} | {2} ", fieldValue[3], fieldValue[4], fieldValue[5]);
            Console.WriteLine("     ---+---+---");
            Console.WriteLine("      {0} | {1} | {2} ", fieldValue[6], fieldValue[7], fieldValue[8]);
            Console.WriteLine("     ¯¯¯¯¯¯¯¯¯¯¯");
        }
        public void Reset() // reset field values
        {
            fieldValue = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        }
    }
}
