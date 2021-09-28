using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac3
{
    class GameField // laukums
    {
        public static string[] fieldValue = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public void Print()
        {
            Console.WriteLine("      {0} | {1} | {2} ", fieldValue[0], fieldValue[1], fieldValue[2]);
            Console.WriteLine("     ---+---+---");
            Console.WriteLine("      {0} | {1} | {2} ", fieldValue[3], fieldValue[4], fieldValue[5]);
            Console.WriteLine("     ---+---+---");
            Console.WriteLine("      {0} | {1} | {2} ", fieldValue[6], fieldValue[7], fieldValue[8]);
            Console.WriteLine("     ¯¯¯¯¯¯¯¯¯¯¯");
        }
        public void Reset()
        {
            int setTo = 0;
            for (int i = 0; i < fieldValue.Length; i++)
            {
                setTo++;
                fieldValue[i] = setTo.ToString();
            }
        }
    }
}
