using System;
using System.Collections.Generic;
using System.Linq;

namespace Quotes.Domain
{
    public class BusinessFactor
    {
        public static readonly BusinessFactor Architect = new BusinessFactor(nameof(Architect).ToLowerInvariant(), 1);
        public static readonly BusinessFactor Plumber = new BusinessFactor(nameof(Plumber).ToLowerInvariant(), (decimal)0.5);
        public static readonly BusinessFactor Programmer = new BusinessFactor(nameof(Programmer).ToLowerInvariant(), (decimal)1.25);

        public string Name { get; set; }
        public decimal Factor { get; set; }
        public BusinessFactor(string name, decimal factor)
        {
            Name = name;
            Factor = factor;
        }

        public static IEnumerable<BusinessFactor> List() => new[] { Architect, Plumber, Programmer };

        public static BusinessFactor FromName(string name)
        {
            var factor = List().SingleOrDefault(s => string.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if (factor == null)
                throw new KeyNotFoundException($"Possible businesses: {string.Join(",", List().Select(s => s.Name))}");

            return factor;
        }
    }
}
