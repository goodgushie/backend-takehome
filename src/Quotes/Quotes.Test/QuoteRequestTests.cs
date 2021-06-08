using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quotes.Domain;

namespace Quotes.Test
{
    [TestClass]
    public class QuoteRequestTests
    {
        [TestMethod]
        [DataRow(6000000, 6000)]
        [DataRow(5999900, 6000)]
        [DataRow(1234, 2)]
        public void BasePremium_ReturnsExpected(int revenue, int expected)
        {
            // Arrange
            var quoteRequest = new QuoteRequest { Revenue = revenue };

            // Act
            var result = quoteRequest.BasePremium;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
