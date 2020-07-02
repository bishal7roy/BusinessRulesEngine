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

        [TestMethod]
        public void RoyaltyDepartment_ReturnsTrue()
        {
            RoyaltyDepartment royalty = new RoyaltyDepartment();

            var result = royalty.Royalty(true);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void RoyaltyDepartment_ReturnsFalse()
        {
            RoyaltyDepartment royalty = new RoyaltyDepartment();

            var result = royalty.Royalty(false);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void SendEmail_ReturnsTrue()
        {
            string toEmailID = "bishalbishal7@gmail.com";
            string subject = "Subject Line";
            string mailBody = "";

            Email email = new Email();
            var result = email.SendEmail(toEmailID, subject, mailBody);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SendEmail_ReturnsFalse()
        {
            string toEmailID = "bishalbishal7@gmail.com;bishal.bishal7@gmail.com";
            string subject = "Subject Line";
            string mailBody = "";

            Email email = new Email();
            var result = email.SendEmail(toEmailID, subject, mailBody);

            Assert.IsFalse(result);
        }
    }
}
