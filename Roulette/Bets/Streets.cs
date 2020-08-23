using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Roulette.Bets
{
    class Streets
    {
        public static string PlayStreets(string luckyNumber)
        {
            string result = "";

            if (luckyNumber == "0" || luckyNumber == "00")
            {
                result = "No Street";
                return result;
            }

            int convertNumber = Int32.Parse(luckyNumber);

            if (Columns.row1.Contains(convertNumber))
            {
                if (convertNumber < 22)
                {
                    result = "Street 1";
                }
                else
                {
                    result = "Street 22";
                }

                return result;
                
            }

            if (Columns.row2.Contains(convertNumber))
            {
                if (convertNumber < 23)
                {
                    result = "Street 2";
                }
                else
                {
                    result = "Street 23";
                }

                return result;
            }

            else if (Columns.row3.Contains(convertNumber))
            {
                if (convertNumber < 24)
                {
                    result = "Street 1";
                }
                else
                {
                    result = "Street 24";
                }
            }

            return result;
        }
    }
}
