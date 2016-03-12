using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MerchantGuide.Test.TranslationNotesTests
{
    [TestClass]
    public class TranslateToRomanNumerals_Should
    {
        private TranslationNotes translationNotes;

        [TestInitialize]
        public void BeforeEachTest()
        {
            translationNotes = new TranslationNotes();
        }

        [TestMethod]
        public void Translate_Valid_Values()
        {
            translationNotes.addTranslation("glob is I");
            translationNotes.addTranslation("prok is V");
            var result = translationNotes.translateToRomanNumeral("glob prok");
            Assert.AreEqual<string>("IV", result);
        }

        [TestMethod]
        public void Throw_Exception_For_Unknown_Word()
        {
            UnknownWordException expectedException = null;
            try
            {
                translationNotes.translateToRomanNumeral("glob");
            }
            catch(UnknownWordException ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
            Assert.AreEqual<string>("glob", expectedException.Word);
        }

        [TestMethod]
        public void Throw_Exception_For_Invalid_Result_Numeral()
        {
            translationNotes.addTranslation("glob is I");
            translationNotes.addTranslation("prok is V");
            InvalidNumeralException expectedException = null;
            try
            {
                translationNotes.translateToRomanNumeral("glob glob prok");
            }
            catch(InvalidNumeralException ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
            Assert.AreEqual<string>("IIV", expectedException.InvalidNumeral);
        }
    }
}
