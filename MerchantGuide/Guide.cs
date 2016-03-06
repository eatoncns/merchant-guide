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
        private TranslationNotes translationNotes;

        public Guide()
        {
            translationNotes = new TranslationNotes();
        }

        public void addTranslation(string translation)
        {
            translationNotes.addTranslation(translation);
        }

        public string ask(string inputQuestion)
        {
            Question question = new Question(inputQuestion);
            if (question.Valid)
            {
                try
                {
                    var romanNumeral = translationNotes.translateToRomanNumeral(question.Value);
                    return question.Value + " is " + RomanNumeralConverter.ConvertToArabic(romanNumeral);
                }
                catch(UnknownWordException ex)
                {
                    return "No translation for " + ex.Word;
                }
            }
            return "I have no idea what you are talking about";
        }
    }
}
