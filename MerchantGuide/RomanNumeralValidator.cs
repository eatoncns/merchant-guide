using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MerchantGuide
{
    public static class RomanNumeralValidator
    {
        private static readonly List<Regex> InvalidPatterns = new List<Regex>
        {
            new Regex(@"I{4,}|X{4,}|C{4,}|M{4,}"),
            new Regex(@"D{2,}|L{2,}|V{2,}"),
            new Regex(@"I[LCDM]"),
            new Regex(@"X[DM]"),
            new Regex(@"V[XLCDM]"),
            new Regex(@"L[CDM]"),
            new Regex(@"DM"),
            new Regex(@"I{2,}[VX]"),
            new Regex(@"X{2,}[LC]"),
            new Regex(@"C{2,}[DM]")
        };

        public static bool IsValidNumeral(string romanNumeral)
        {
            foreach (Regex invalidPattern in InvalidPatterns)
            {
                if (invalidPattern.IsMatch(romanNumeral))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
