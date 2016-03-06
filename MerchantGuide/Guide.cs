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
        private Dictionary<string, char> wordToNumeralDictionary;

        public Guide()
        {
            this.wordToNumeralDictionary = new Dictionary<string, char>();
        }

        public void addTranslation(string translation)
        {
            Match match = Regex.Match(translation, @"([a-zA-Z]+) is ([IVXLCDM])");
            if (match.Success)
            {
                var word = match.Groups[1].ToString();
                var romanNumeral = match.Groups[2].ToString()[0];
                this.wordToNumeralDictionary.Add(word, romanNumeral);
            }
        }

        public string ask(string inputQuestion)
        {
            Question question = new Question(inputQuestion);
            if (question.Valid)
            {
                var romanNumeral = translateToRomanNumeral(question.Value);
                return question.Value + " is " + RomanNumeralConverter.ConvertToArabic(romanNumeral); 
            }
            return "I have no idea what you are talking about";
        }

        private string translateToRomanNumeral(string value)
        {
            var romanNumeral = "";
            foreach (string word in value.Split(' '))
            {
                romanNumeral += wordToNumeralDictionary[word].ToString();
            }
            return romanNumeral;
        }
    }
}
