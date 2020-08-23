using System;

namespace Roulette.Bets
{
    public class RedsBlacks
    {
        public static string PlayRedsBlacks(string luckyColor)
        {
            string result = "";

            if (luckyColor == "green")
            {
                result = "Neither";
            }

            if (luckyColor == "red")
            {
                result = "Red";
            }

            else if (luckyColor == "black")
            {
                result = "Black";
            }

            return result;

        }
    }
}