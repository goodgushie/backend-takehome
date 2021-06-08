using System;
using System.Collections.Generic;
using System.Linq;

namespace Quotes.Domain
{
    public class StateFactor
    {
        public static readonly StateFactor OH = new StateFactor(nameof(OH).ToLowerInvariant(), 1);
        public static readonly StateFactor FL = new StateFactor(nameof(FL).ToLowerInvariant(), (decimal)1.2);
        public static readonly StateFactor TX = new StateFactor(nameof(TX).ToLowerInvariant(), (decimal).943);

        public string Abbreviation { get; set; }
        public decimal Factor { get; set; }
        public StateFactor(string abbreviation, decimal factor)
        {
            Abbreviation = abbreviation;
            Factor = factor;
        }

        public static IEnumerable<StateFactor> List() => new[] { OH, FL, TX };

        public static StateFactor FromAbbreviation(string abbr)
        {
            var factor = List().SingleOrDefault(s => string.Equals(s.Abbreviation, abbr, StringComparison.CurrentCultureIgnoreCase));

            if (factor == null)
                throw new KeyNotFoundException($"Possible states: {string.Join(",", List().Select(s => s.Abbreviation))}");

            return factor;
        }
    }
}
