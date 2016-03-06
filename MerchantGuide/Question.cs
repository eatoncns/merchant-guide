using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MerchantGuide
{
    public class Question
    {
        private static readonly Regex valueRegex = new Regex(@"how much is ([a-zA-Z ]+)\?");
        private string value;

        public Question(string question)
        {
            Match match = valueRegex.Match(question);
            if (match.Success)
            {
                this.value = match.Groups[1].ToString();
            }
        }

        public bool Valid
        {
            get { return null != value; }
        }

        public string Value
        {
            get { return value; }
        }
    }
}
