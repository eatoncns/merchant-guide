using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MerchantGuide
{
    public class TranslationNotes
    {
        private static readonly Regex translationRegex = new Regex(@"([a-zA-Z]+) is ([IVXLCDM])");
        private Dictionary<string, string> wordToNumeralDictionary;

        public TranslationNotes()
        {
            wordToNumeralDictionary = new Dictionary<string, string>();
        }

        public void addTranslation(string translation)
        {
            Match match = translationRegex.Match(translation);
            if (match.Success)
            {
                var word = match.Groups[1].ToString();
                var romanNumeral = match.Groups[2].ToString();
                wordToNumeralDictionary.Add(word, romanNumeral);
            }
        }

        public string translateToRomanNumeral(string value)
        {
            var romanNumeral = "";
            foreach (string word in value.Split(' '))
            {
                if (!wordToNumeralDictionary.ContainsKey(word))
                {
                    throw new UnknownWordException(word);
                }
                romanNumeral += wordToNumeralDictionary[word].ToString();

            }
            return romanNumeral;
        }
    }
}
