using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MerchantGuide
{
    public class Guide
    {
        private Dictionary<string, char> dictionary;

        public Guide()
        {
            this.dictionary = new Dictionary<string, char>();
        }

        public void addTranslation(string translation)
        {
            Match match = Regex.Match(translation, @"([a-zA-Z]+) is ([IVXLCDM])");
            if (match.Success)
            {
                var word = match.Groups[1].ToString();
                var romanNumeral = match.Groups[2].ToString()[0];
                this.dictionary.Add(word, romanNumeral);
            }
        }

        public string ask(string question)
        {
            Match match = Regex.Match(question, @"how much is ([a-zA-Z ]+)\?");
            if (match.Success)
            {
                var valueString = match.Groups[1].ToString();
                var romanNumeral = "";
                foreach (string word in valueString.Split(' '))
                {
                    romanNumeral += translateWord(word);
                }
                return valueString + " is " + RomanNumeralConverter.ConvertToArabic(romanNumeral); 
            }
            return "I have no idea what you are talking about";
        }

        private string translateWord(string word)
        {
            return dictionary[word].ToString();
        }
    }
}
