using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MerchantGuide.Test.RomanNumeralConverterTests
{
    [TestClass]
    public class Convert_Should
    {
        [TestMethod]
        public void Translate_Numerals_Correctly()
        {
            Assert.AreEqual<string>("1", RomanNumeralConverter.ConvertToArabic("I"));
            Assert.AreEqual<string>("2", RomanNumeralConverter.ConvertToArabic("II"));
            Assert.AreEqual<string>("4", RomanNumeralConverter.ConvertToArabic("IV"));
            Assert.AreEqual<string>("5", RomanNumeralConverter.ConvertToArabic("V"));
            Assert.AreEqual<string>("10", RomanNumeralConverter.ConvertToArabic("X"));
            Assert.AreEqual<string>("2006", RomanNumeralConverter.ConvertToArabic("MMVI"));
            Assert.AreEqual<string>("1944", RomanNumeralConverter.ConvertToArabic("MCMXLIV"));
        }
    }
}
