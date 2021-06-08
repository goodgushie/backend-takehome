using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quotes.Domain;
using System.Collections.Generic;

namespace Quotes.Test
{
    [TestClass]
    public class StateFactorTests
    {
        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void FromAbbreviation_UnknownState_ThrowsException()
        {
            // Arrange
            // Act
            // Assert
            StateFactor.FromAbbreviation("ZZ");
        }
    }
}
