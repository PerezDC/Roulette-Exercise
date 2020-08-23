using System;

namespace Roulette.Bets
{
    public class EvensOdds
    {
        public static string PlayEvensOdds(string luckyNumber)
        {
            string result = "";

            if (luckyNumber == "0" || luckyNumber == "00")
            {
                result = "Neither";
                return result;
            }
            int convertNumber = Int32.Parse(luckyNumber);

            convertNumber %= 2;

            if (convertNumber == 0)
            {
                result = "Even";
            }

            else if (convertNumber != 0)
            {
                result = "Odd";
            }

            return result;

        }
    }
}