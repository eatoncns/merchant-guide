using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MerchantGuide.Test.GuideTests
{
    [TestClass]
    public class Ask_Should
    {
        private Guide guide;

        [TestInitialize]
        public void BeforeEachTest()
        {
            guide = new Guide();
        }

        [TestMethod]
        public void Perform_Single_Word_Translation()
        {
            guide.addTranslation("glob is I");
            var answer = guide.ask("how much is glob?");
            Assert.AreEqual<string>("glob is 1", answer);
        }

        [TestMethod]
        public void Return_String_Beginning_With_Question_Textual_Value()
        {
            guide.addTranslation("foo is I");
            var answer = guide.ask("how much is foo?");
            Assert.AreEqual<string>("foo is 1", answer);
        }

        [TestMethod]
        public void Return_Error_String_For_Questions_It_Does_Not_Recognise()
        {
            var answer = guide.ask("how much wood could a woodchuck chuck if a woodchuck could chuck wood?");
            Assert.AreEqual<string>("I have no idea what you are talking about", answer);
        }

        [TestMethod]
        public void Return_String_Containing_Correct_Translation_From_Roman_Numeral()
        {
            guide.addTranslation("glob is V");
            var answer = guide.ask("how much is glob?");
            Assert.AreEqual<string>("glob is 5", answer);
        }
    }
}
