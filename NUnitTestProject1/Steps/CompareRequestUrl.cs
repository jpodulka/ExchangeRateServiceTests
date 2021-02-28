using NUnit.Framework;
using NUnitTestProject1.Models;
using TechTalk.SpecFlow;

namespace NUnitTestProject1.Steps
{
    [Binding]
    public sealed class CompareRequestUrl
    {
        private readonly BaseContext _baseContext;
        private const string url = "https://api.exchangeratesapi.io/latest";

        public CompareRequestUrl(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }

        [Then(@"I should have same url after execution")]
        public void ThenIShouldHaveSameUrlAfterExecution()
        {
            Assert.AreEqual(url, _baseContext.response.ResponseUri.ToString());
        }

    }
}
