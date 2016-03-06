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
        public void Perform_Simple_Translation()
        {
            guide.addTranslation("glob is I");
            var result = guide.ask("how much is glob?");
            Assert.AreEqual<string>("glob is 1", result);
        }

        [TestMethod]
        public void Return_String_Beginning_With_Question_Textual_Value()
        {
            guide.addTranslation("foo is I");
            var result = guide.ask("how much is foo?");
            Assert.AreEqual<string>("foo is 1", result);
        }

        [TestMethod]
        public void Return_Error_String_For_Questions_It_Does_Not_Recognise()
        {
            var result = guide.ask("how much wood could a woodchuck chuck if a woodchuck could chuck wood?");
            Assert.AreEqual<string>("I have no idea what you are talking about", result);
        }
    }
}
