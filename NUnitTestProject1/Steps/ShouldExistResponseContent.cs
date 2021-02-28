using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnitTestProject1.Models;
using TechTalk.SpecFlow;

namespace NUnitTestProject1.Steps
{
    [Binding]
    public sealed class ShouldExistResponseContent
    {
        private BaseContext _baseContext;

        public ShouldExistResponseContent(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }

        [Then(@"I should have content")]
        public void ThenIShouldHaveContent()
        {
            Assert.IsTrue(_baseContext.response.Content.Length > 0);
        }

    }
}
