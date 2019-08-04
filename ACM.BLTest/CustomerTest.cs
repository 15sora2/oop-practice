using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Tom",
                LastName = "Sawyer"
            };

            var expectedFullName = "Sawyer, Tom";

            //Act (perform the operation(s) we are testing)
            var actualfullName = customer.FullName;

            //Assert
            Assert.AreEqual(expectedFullName, actualfullName);
        }

        [TestMethod]
        public void EmptyFirstNameInFullName()
        {
            Customer customer = new Customer
            {
                LastName = "Sawyer"
            };

            string expectedFullName = "Sawyer";

            string actualFullName = customer.FullName;

            Assert.AreEqual(actualFullName, expectedFullName);
        }

        [TestMethod]
        public void EmptyLastNameInFullName()
        {
            Customer customer = new Customer
            {
                FirstName = "Tom"
            };

            string expectedFullName = "Tom";

            string actualFullName = customer.FullName;

            Assert.AreEqual(actualFullName, expectedFullName);
        }

        [TestMethod]
        public void StaticTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Tom";
            Customer.instanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Mike";
            Customer.instanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Mary";
            Customer.instanceCount += 1;

            Assert.AreEqual(3, Customer.instanceCount);
        }
    }
}
