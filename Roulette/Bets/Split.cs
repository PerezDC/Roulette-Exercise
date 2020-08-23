using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Roulette.Bets
{
    class Split
    {
        public static string PlaySplits(string luckyNumber)
        {
            string result = "";

            if (luckyNumber == "0" || luckyNumber == "00")
            {
                result = "No splits available";
                return result;
            }

            int convertNumber = Int32.Parse(luckyNumber);

            if (convertNumber == 1)
            {
                result = $"{convertNumber} can be split with 2 and 4";
                return result;
            }

            else if (convertNumber == 2)
            {
                result = $"{convertNumber} can be split with 1, 5, and 3";
                return result;
            }

            else if (convertNumber == 3)
            {
                result = $"{convertNumber} can be split with 2 and 6";
                return result;
            }

            else if (convertNumber == 34)
            {
                result = $"{convertNumber} can be split with 31 and 35";
                return result;
            }

            else if (convertNumber == 35)
            {
                result = $"{convertNumber} can be split with 34, 32, and 36";
                return result;
            }

            else if (convertNumber == 35)
            {
                result = $"{convertNumber} can be split with 33 and 35";
                return result;
            }

            else if (Columns.row1.Contains(convertNumber) && convertNumber >= 4 && convertNumber <= 31)
            {
                result = $"{convertNumber} can be split with {convertNumber -3}, {convertNumber + 1}, and {convertNumber + 3}";
                return result;
            }

            else if (Columns.row2.Contains(convertNumber) && convertNumber >= 5 && convertNumber <= 32)
            {
                result = $"{convertNumber} can be split with {convertNumber - 3}, {convertNumber - 1}, {convertNumber + 1}, and {convertNumber + 3}";
                return result;
            }

            else if (Columns.row3.Contains(convertNumber) && convertNumber >= 6 && convertNumber <= 33)
            {
                result = $"{convertNumber} can be split with {convertNumber - 3}, {convertNumber - 1}, and {convertNumber + 3}";
            }

            return result;
        }

    }
}
