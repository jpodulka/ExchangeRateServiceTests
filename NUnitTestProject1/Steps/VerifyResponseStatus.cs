using System.Net;
using NUnit.Framework;
using NUnitTestProject1.Models;
using TechTalk.SpecFlow;

namespace NUnitTestProject1.Steps
{
    [Binding]
    public sealed class VerifyResponseStatus
    {
        private BaseContext _baseContext;
        public VerifyResponseStatus(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }

        [Then(@"I should have Ok status")]
        public void ThenIShouldHaveOkStatus()
        {
            Assert.AreEqual(HttpStatusCode.OK, _baseContext.response.StatusCode);
        }

    }
}
