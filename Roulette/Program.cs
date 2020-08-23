using System;
using Roulette.Bets;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EX 8A - C# - Roulette");
            Console.WriteLine("David Perez - 08/22/2020\n");

            int luckyColorIndex = Wheel.ColorIndex();
            string luckyColor = Wheel.NumberColors[luckyColorIndex];
            string luckyNumber = Wheel.GetNumber(luckyColor);

            Console.WriteLine($"Your ball landed in {luckyColor}: {luckyNumber}.");
            Console.WriteLine($"Evens or Odds bet: {EvensOdds.PlayEvensOdds(luckyNumber)}!");
            Console.WriteLine($"Reds or Blacks bet: {RedsBlacks.PlayRedsBlacks(luckyColor)}!");
            Console.WriteLine($"Lows or Highs bet: {LowsHighs.PlayLowHighs(luckyNumber)}!");
            Console.WriteLine($"Dozens bet: {Dozens.PlayDozens(luckyNumber)}!");
            Console.WriteLine($"Columns bet: {Columns.PlayColumns(luckyNumber)}!");
            Console.WriteLine($"Streets bet: {Streets.PlayStreets(luckyNumber)}!");
            Console.WriteLine($"6 Numbers bet: {SixNumbers.PlaySixNumbers(luckyNumber)}!");
            Console.WriteLine($"Split bet: {Split.PlaySplits(luckyNumber)}!");
            Console.WriteLine($"Corner bet: {Corner.PlayCorners(luckyNumber)}");
        }
    }
}
