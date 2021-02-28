using Newtonsoft.Json;
using NUnit.Framework;
using NUnitTestProject1.Models;
using TechTalk.SpecFlow;

namespace NUnitTestProject1.Steps
{
    [Binding]
    public sealed class VerifyExchangeRateBaseCurrency
    {
        private BaseContext _baseContext;

        public VerifyExchangeRateBaseCurrency(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }

        [Then(@"I should euro base currency")]
        public void ThenIShouldEuroBaseCurrency()
        {
            var content = JsonConvert.DeserializeObject<ExchangeRateResponseContent>(_baseContext.response.Content);
            Assert.AreEqual(content.Base, "EUR");
        }

    }
}
