using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roulette.Bets
{
    class Columns
    {

        public static int[] row1 = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
        public static int[] row2 = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
        public static int[] row3 = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };

        public static string PlayColumns(string luckyNumber)
        {
            string result = "";

            if (luckyNumber == "0" || luckyNumber == "00")
            {
                result = "No Column";
                return result;
            }

            int convertNumber = Int32.Parse(luckyNumber);

            if (row1.Contains(convertNumber))
            {
                result = "Column 1";
            }

            if (row2.Contains(convertNumber))
            {
                result = "Column 2";
            }

            else if (row3.Contains(convertNumber))
            {
                result = "Column 3";
            }

            return result;
        }
    }
}
