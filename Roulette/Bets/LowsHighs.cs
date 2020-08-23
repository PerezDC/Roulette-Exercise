using System;

namespace Roulette.Bets
{
    public class LowsHighs
    {
        public static string PlayLowHighs(string luckyNumber)
        {
            string result = "";

            if (luckyNumber == "0" || luckyNumber == "00")
            {
                result = "Neither";
                return result;
            }
            int convertNumber = Int32.Parse(luckyNumber);

            if (convertNumber < 19)
            {
                result = "Low";
            }

            else if (convertNumber > 18)
            {
                result = "High";
            }

            return result;

        }
    }
}