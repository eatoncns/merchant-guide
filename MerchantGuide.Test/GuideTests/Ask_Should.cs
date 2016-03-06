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
        public void Return_String_Beginning_With_Question_Textual_Value()
        {
            guide.addTranslation("foo is I");
            var answer = guide.ask("how much is foo?");
            StringAssert.StartsWith(answer, "foo is ");
        }

        [TestMethod]
        public void Return_Error_String_For_Questions_It_Does_Not_Recognise()
        {
            var answer = guide.ask("how much wood could a woodchuck chuck if a woodchuck could chuck wood?");
            Assert.AreEqual<string>("I have no idea what you are talking about", answer);
        }

        [TestMethod]
        public void Return_Error_String_When_Unknown_Word_In_Question()
        {
            var answer = guide.ask("how much is foo?");
            Assert.AreEqual<string>("No translation for foo", answer);
        }

        [TestMethod]
        public void Perform_Single_Word_Translation()
        {
            guide.addTranslation("glob is I");
            var answer = guide.ask("how much is glob?");
            StringAssert.EndsWith(answer, " 1");
        }

        [TestMethod]
        public void Perform_Multi_Word_Translation()
        {
            guide.addTranslation("glob is I");
            var answer = guide.ask("how much is glob glob?");
            StringAssert.EndsWith(answer, " 2");
        }

        [TestMethod]
        public void Perform_Multi_Word_Multi_Translation()
        {
            guide.addTranslation("glob is I");
            guide.addTranslation("prok is V");
            var answer = guide.ask("how much is glob prok?");
            StringAssert.EndsWith(answer, " 4");
        }
    }
}
