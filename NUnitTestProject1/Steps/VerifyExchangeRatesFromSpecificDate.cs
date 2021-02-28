using Newtonsoft.Json;
using NUnit.Framework;
using NUnitTestProject1.Models;
using TechTalk.SpecFlow;

namespace NUnitTestProject1.Steps
{
    [Binding]
    public sealed class VerifyExchangeRatesFromSpecificDate
    {
        private BaseContext _baseContext;

        public VerifyExchangeRatesFromSpecificDate(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }

        [Then(@"I should have exactly same exchange rate CAD like in database")]
        public void ThenIShouldHaveExactlySameExchangeRateCADLikeInDatabase()
        {
            var rates = GetRatesFrom26022021();
            var content = JsonConvert.DeserializeObject<ExchangeRateResponseContent>(_baseContext.response.Content);

            Assert.AreEqual(rates.CAD, content.Rates.CAD);
        }

        private static Rates GetRatesFrom26022021()
        {
            //It is of course hardcoded for 26022021 due to not having connection to database and it will be not working on 27.02.2021 while verifying
            return new  Rates
                {
                    CAD = 1.5331,
                    HKD = 9.401,
                    ISK = 152.9,
                    PHP = 59.09,
                    DKK = 7.4361,
                    HUF = 361.43,
                    CZK = 26.195,
                    AUD = 1.5605,
                    RON = 4.875,
                    SEK = 10.1388,
                    IDR = 17353.51,
                    INR = 89.5766,
                    BRL = 6.6644,
                    RUB = 90.6697,
                    HRK = 7.583,
                    JPY = 128.83,
                    THB = 36.799,
                    CHF = 1.0986,
                    SGD = 1.6106,
                    PLN = 4.5186,
                    BGN = 1.9558,
                    TRY = 9.0168,
                    CNY = 7.8385,
                    NOK = 10.4012,
                    NZD = 1.6622,
                    ZAR = 18.1025,
                    USD = 1.2121,
                    MXN = 25.2879,
                    ILS = 4.0072,
                    GBP = 0.87053,
                    KRW = 1367.1,
                    MYR = 4.9096
                
            };
        }

    }
}
