using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MerchantGuide.Test.QuestionTests
{
    [TestClass]
    public class Constructor_Should
    {
        private Question question;

        [TestMethod]
        public void Set_Invalid_Status_When_Input_Is_Invalid()
        {
            question = new Question("how much wood could a woodchuck chuck if a woodchuck could chuck wood?");
            Assert.IsFalse(question.Valid);
        }

        [TestMethod]
        public void Extract_Value_From_Valid_Input()
        {
            question = new Question("how much is pish tegj glob glob?");
            Assert.AreEqual<string>("pish tegj glob glob", question.Value);
        }
    }
}
