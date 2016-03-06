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
    }
}
