using System;

namespace Roulette
{
    public class Wheel
    {
        public static Random RandomSpin = new Random();
        public static string[] NumberColors = new string[] {"red", "black", "green"};
        public static string[] RedNumbers = new string[] {"1", "3", "5", "7", "9", "12", "14", "16", "18", "19", "21", "23", "25", "27", "30", "32", "34", "36" };
        public static string[] BlackNumbers = new string[] {"2", "4", "6", "8", "10", "11", "13", "15", "17", "20", "22", "24", "26", "28", "29", "31", "33", "35" };
        public static string[] GreenNumbers = new string[] { "0", "00" };

        public static int ColorIndex()
        {
            return RandomSpin.Next(NumberColors.Length);
        }

        public static string GetNumber(string color)
        {
            string returnNumber = "";

            if (color == "red")
            {
                int redReturnNumber = RandomSpin.Next(RedNumbers.Length);
                returnNumber = RedNumbers[redReturnNumber];
            }

            if (color == "black")
            {
                int blackReturnNumber = RandomSpin.Next(BlackNumbers.Length);
                returnNumber = BlackNumbers[blackReturnNumber];
            }

            if (color == "green")
            {
                int greenReturnNumber = RandomSpin.Next(GreenNumbers.Length);
                returnNumber = GreenNumbers[greenReturnNumber];
            }

            return returnNumber;
        }
    }
}