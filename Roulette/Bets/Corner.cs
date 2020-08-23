using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Roulette.Bets
{
    class Corner
    {
        public static string PlayCorners(string luckyNumber)
        {
            string result = "";

            if (luckyNumber == "0" || luckyNumber == "00")
            {
                result = "No corners available";
                return result;
            }

            int convertNumber = Int32.Parse(luckyNumber);

            if (convertNumber == 1)
            {
                result = $"{convertNumber} corner: 1, 2, 4, 5";
                return result;
            }

            else if (convertNumber == 2)
            {
                result = $"{convertNumber} corners: 1, 2, 4, 5 || 2, 3, 5, 6";
                return result;
            }

            else if (convertNumber == 3)
            {
                result = $"{convertNumber} corner: 2, 3, 5, 6";
                return result;
            }

            else if (convertNumber == 34)
            {
                result = $"{convertNumber} corner 31, 32, 34, 35";
                return result;
            }

            else if (convertNumber == 35)
            {
                result = $"{convertNumber} corners: 31, 32, 34, 35 || 32, 33, 35, 36";
                return result;
            }

            else if (convertNumber == 36)
            {
                result = $"{convertNumber} corners: 32, 33, 35, 36";
                return result;
            }


            else if (Columns.row1.Contains(convertNumber) && convertNumber >= 4 && convertNumber <= 31)
            {
                result = $"{convertNumber} corners: {convertNumber - 3}, {convertNumber - 2}, {convertNumber}, {convertNumber + 1} || {convertNumber}, {convertNumber + 1}, {convertNumber + 3}, {convertNumber + 4}";
                return result;
            }

            else if (Columns.row2.Contains(convertNumber) && convertNumber >= 5 && convertNumber <= 32)
            {
                result = $"{convertNumber} corners: {convertNumber - 4}, {convertNumber - 3}, {convertNumber - 1}, {convertNumber} || " +
                         $"{convertNumber - 3}, {convertNumber - 2}, {convertNumber}, {convertNumber + 1} || " +
                         $"{convertNumber - 1}, {convertNumber}, {convertNumber + 2}, {convertNumber + 3} || " +
                         $"{convertNumber}, {convertNumber + 1}, {convertNumber + 3}, {convertNumber + 4}";
                return result;
            }

            else if (Columns.row3.Contains(convertNumber) && convertNumber >= 6 && convertNumber <= 33)
            {
                result =
                    $"{convertNumber} corners: {convertNumber - 4}, {convertNumber - 3}, {convertNumber - 1}, {convertNumber} || " +
                    $"{convertNumber - 1}, {convertNumber}, {convertNumber + 2}, {convertNumber + 3}";
                return result;
            }

            return result;
        }
    }
}
