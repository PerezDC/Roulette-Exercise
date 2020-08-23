using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette.Bets
{
    class SixNumbers
    {
        public static string PlaySixNumbers(string luckyNumber)
        {
            string result = "";

            if (luckyNumber == "0" || luckyNumber == "00")
            {
                result = "No Column";
                return result;
            }

            int convertNumber = Int32.Parse(luckyNumber);

            if (convertNumber > 0 && convertNumber < 7)
            {
                result = "Double Rows 1 - 6";
            }

            if (convertNumber > 6 && convertNumber < 13)
            {
                result = "Double Rows 7 - 12";
            }

            if (convertNumber > 12 && convertNumber < 19)
            {
                result = "Double Rows 13 - 18";
            }

            if (convertNumber > 18 && convertNumber < 25)
            {
                result = "Double Rows 19 - 24";
            }

            if (convertNumber > 24 && convertNumber < 31)
            {
                result = "Double Rows 25 - 30";
            }

            else if (convertNumber > 30 && convertNumber < 37)
            {
                result = "Double Rows 30 - 37";
            }

            return result;
        }
    }
}