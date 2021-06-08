using System;
using System.Text.Json.Serialization;

namespace Quotes.Domain
{
    public class QuoteRequest
    {
        public decimal Revenue { get; set; }
        public string State { get; set; }
        public string Business { get; set; }

        [JsonIgnore]
        public decimal BasePremium
        {
            get { return Math.Ceiling(Revenue / 1000); }
        }

        public Quote CreateQuote()
        {
            return new Quote(BasePremium, (decimal).943, (decimal).5);
        }
    }
}
