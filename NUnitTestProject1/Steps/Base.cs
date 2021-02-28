using NUnitTestProject1.Models;
using RestSharp;
using TechTalk.SpecFlow;

namespace ExchangeRateServiceTests.Steps
{

    [Binding]
    public sealed class Base
    {
        private readonly BaseContext _baseContext;
        private RestClient RestClient;
        private const string url = "https://api.exchangeratesapi.io/latest";

        public Base(BaseContext baseContext)
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
    }
}
