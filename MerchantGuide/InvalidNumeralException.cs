using System;
using System.Runtime.Serialization;

namespace MerchantGuide
{
    public class InvalidNumeralException : Exception
    {
        public InvalidNumeralException(string invalidNumeral) : base("Invalid numeral " + invalidNumeral)
        {
            numeral = invalidNumeral;
        }

        public string InvalidNumeral
        {
            get { return numeral; }
        }

        private string numeral;
    }
}