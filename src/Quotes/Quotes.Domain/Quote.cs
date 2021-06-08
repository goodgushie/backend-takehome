using System;

namespace Quotes.Domain
{
    public class Quote
    {
        public decimal Premium { get; set; }

        public Quote(decimal stateFactor, decimal businessFactor, decimal basePremium, int hazardFactor = 4)
        {
            Premium = Math.Round(stateFactor * businessFactor * basePremium * hazardFactor, 2);
        }
    }
}
