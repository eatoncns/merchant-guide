using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGuide
{
    public static class RomanNumeralConverter
    {
        private static readonly Dictionary<char, int> numeralConversion = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public static string ConvertToArabic(string romanNumeral)
        {
           
            int result = 0;
            int last = 0;
            foreach (char numeral in romanNumeral.Reverse())
            {
                var value = numeralConversion[numeral];
                var addition = (value < last) ? -value : value;
                result += addition;
                last = value;
            }
            return result.ToString();
        }
    }
}
