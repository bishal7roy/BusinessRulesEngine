using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessRulesEngine.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InputUserValue_ReturnsValue()
        {
            ProductDetails productDetails = new ProductDetails();

            var result = productDetails.InputUserValue(1);

            Assert.AreEqual(result, 1);

        }
    }
}
