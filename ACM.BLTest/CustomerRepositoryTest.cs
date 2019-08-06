using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValidCustomer()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expectedCustomer = new Customer(1)
            {
                EmailAddress = "tsawyer@hobbition.me",
                FirstName = "Tom",
                LastName = "Sawyer"
        };

            //Act
            var actualCustomer = customerRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expectedCustomer.EmailAddress, actualCustomer.EmailAddress);
            Assert.AreEqual(expectedCustomer.FirstName, actualCustomer.FirstName);
            //Assert.AreEqual(expectedCustomer, actualCustomer);
            //Assert.AreEqual(expectedCustomer, actualCustomer);
        }
    }
}
