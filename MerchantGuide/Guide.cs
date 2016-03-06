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
        private string translation;

        public void addTranslation(string translation)
        {
            this.translation = translation;
        }

        public string ask(string question)
        {
            Match match = Regex.Match(question, @"how much is ([a-zA-Z]+)");
            if (match.Success)
            {
                return match.Groups[1].ToString() + " is 1";
            }
            return "I have no idea what you are talking about";
        }
    }
}
