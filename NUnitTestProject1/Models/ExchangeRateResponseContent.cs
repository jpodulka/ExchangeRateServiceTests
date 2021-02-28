using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.Models
{
    public class ExchangeRateResponseContent
    {
        public Rates Rates { get; set; }
        public string Base { get; set; }
        public string Date { get; set; }
    }
}
