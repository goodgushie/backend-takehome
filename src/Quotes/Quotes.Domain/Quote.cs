namespace Quotes.Domain
{
    public class Quote
    {
        public decimal Premium { get; set; }

        public Quote(decimal stateFactor, decimal businessFactor, decimal basePremium, int hazardFactor)
        {
            // TODO: put in something to round decimal to 2 places
            Premium = stateFactor * businessFactor * basePremium * hazardFactor;
        }
    }
}
