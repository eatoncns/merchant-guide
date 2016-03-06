using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGuide
{
    public class UnknownWordException : Exception
    {
        public UnknownWordException(string unknownWord) : base("Unknown word " + unknownWord)
        {
            word = unknownWord;
        }

        public string Word {
            get { return word; }
        }

        private string word;
    }
}
