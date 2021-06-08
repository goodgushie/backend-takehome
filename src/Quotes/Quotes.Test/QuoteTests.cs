using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quotes.Domain;

namespace Quotes.Test
{
    [TestClass]
    public class QuoteTests
    {
        [TestMethod]
        [DataRow(.943, .5, 6000, 4, 11316)]
        public void QuoteConstructor_SetsExpectedPremuim(double stateFactor, double businessFactor, int basePremium, int hazardFactor, int expected)
        {
            // Arrange
            var quote = new Quote((decimal)stateFactor, (decimal)businessFactor, basePremium, hazardFactor);

            // Act
            var result = quote.Premium;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
