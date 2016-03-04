using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace MerchantGuide.Acceptance
{
    [Binding]
    public class NumberTranslationSteps
    {
        [Given(@"translation (.*)")]
        public void GivenTranslation(string translation)
        {
            var guide = new Guide(translation);
            ScenarioContext.Current.Set<Guide>(guide);
        }
        
        [When(@"I ask (.*)")]
        public void WhenIAsk(string question)
        {
            var guide = ScenarioContext.Current.Get<Guide>();
            var result = guide.ask(question);
            ScenarioContext.Current.Set<int>(result);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            var actualResult = ScenarioContext.Current.Get<int>();
            Assert.AreEqual<int>(expectedResult, actualResult);
        }
    }
}
