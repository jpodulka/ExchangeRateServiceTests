using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnitTestProject1.Models;
using RestSharp;
using TechTalk.SpecFlow;

namespace NUnitTestProject1.Steps
{
    [Binding]
    public sealed class CompareRequestUrl
    {
        private readonly BaseContext _baseContext;
        private RestClient RestClient;
        private const string url = "https://api.exchangeratesapi.io/latest";

        public CompareRequestUrl(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }

        [Given(@"I created request with Url")]
        public void GivenICreatedRequestWithUrl()
        {
            RestClient = new RestClient(url);
        }

        [Given(@"I executed the request")]
        public void GivenIExecutedTheRequest()
        {
            var request = new RestRequest(Method.GET);
            _baseContext.response = RestClient.Execute(request);
        }

        [Then(@"I should have same url after execution")]
        public void ThenIShouldHaveSameUrlAfterExecution()
        {
            Assert.AreEqual(url, _baseContext.response.ResponseUri.ToString());
        }

    }
}
