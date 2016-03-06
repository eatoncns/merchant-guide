using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantGuide
{
    public class Guide
    {
        private string translation;

        public Guide(string translation)
        {
            this.translation = translation;
        }

        public string ask(string question)
        {
            return "glob is 1";
        }
    }
}
