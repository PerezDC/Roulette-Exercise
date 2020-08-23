using System;


namespace Roulette.Bets
{
    class Dozens
    {
        public static string PlayDozens(string luckyNumber)
        {
            string result = "";

            if (luckyNumber == "0" || luckyNumber == "00")
            {
                result = "No Row";
                return result;
            }

            int convertNumber = Int32.Parse(luckyNumber);

            if (convertNumber > 0 && convertNumber < 13)
            {
                result = "Row 1";
            }

            if (convertNumber > 12 && convertNumber < 25)
            {
                result = "Row 2";
            }

            if (convertNumber > 24 && convertNumber < 37)
            {
                result = "Row 3";
            }

            return result;
        }
    }
}