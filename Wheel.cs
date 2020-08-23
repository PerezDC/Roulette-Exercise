using System;

namespace Roulette.RouletteWheel
{
    public class Wheel
    {
        string[] numberColors = new string[] { "red", "black", "green" };
        int[] redNumbers = new[] { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
        int[] blackNumbers = new[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
        int[] greenNumbers = new[] { 1, 2 }; // 1 will represent 0 and 2 will represent 00

        Random spin = new Random();


        public static int GetNumber()
        {
            int myRandomColor = spin.Next(numberColors.Length);
            string color = numberColors[myRandomColor];
        }
    }
}

