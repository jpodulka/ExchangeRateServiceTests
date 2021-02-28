using System;
using Newtonsoft.Json;
using NUnit.Framework;
using NUnitTestProject1.Models;
using TechTalk.SpecFlow;

namespace NUnitTestProject1.Steps
{
    [Binding]
    public sealed class VerifyDateFromResponse
    {
        private BaseContext _baseContext;
        private DateTime lastWorkingDay = DateTime.Now;

        public VerifyDateFromResponse(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }

        [Then(@"I should have latest date")]
        public void ThenIShouldHaveLatestDate()
        {
            var content = JsonConvert.DeserializeObject<ExchangeRateResponseContent>(_baseContext.response.Content);
            var expectedDate = new DateTime();
            if (lastWorkingDay.DayOfWeek == DayOfWeek.Sunday)
            {
                expectedDate = lastWorkingDay.AddDays(-2);
            }
                
            if (lastWorkingDay.DayOfWeek == DayOfWeek.Saturday)
            {
                expectedDate = lastWorkingDay.AddDays(-1);
            }

            Assert.AreEqual(expectedDate.Date.ToString("yyyy'-'MM'-'dd"), content.Date);
        }

    }
}
