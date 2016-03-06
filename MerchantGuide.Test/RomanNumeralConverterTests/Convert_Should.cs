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
            Assert.AreEqual<int>(1, RomanNumeralConverter.Convert("I"));
            Assert.AreEqual<int>(2, RomanNumeralConverter.Convert("II"));
            Assert.AreEqual<int>(4, RomanNumeralConverter.Convert("IV"));
            Assert.AreEqual<int>(5, RomanNumeralConverter.Convert("V"));
            Assert.AreEqual<int>(10, RomanNumeralConverter.Convert("X"));
            Assert.AreEqual<int>(2006, RomanNumeralConverter.Convert("MMVI"));
            Assert.AreEqual<int>(1944, RomanNumeralConverter.Convert("MCMXLIV"));
        }
    }
}
