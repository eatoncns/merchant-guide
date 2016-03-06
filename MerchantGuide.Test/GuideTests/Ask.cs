using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MerchantGuide.Test.GuideTests
{
    [TestClass]
    public class Ask
    {
        [TestMethod]
        public void ShouldPerformSimpleTranslation()
        {
            var guide = new Guide("glob is I");
            var result = guide.ask("How much is glob?");
            Assert.AreEqual<string>("glob is 1", result);
        }
    }
}
