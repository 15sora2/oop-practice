using System;
using System.Collections.Generic;
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

        [TestMethod]
        public void RetrieveExistingCustomerWithAddress()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expectedCustomer = new Customer(1)
            {
                EmailAddress = "tsawyer@hobbition.me",
                FirstName = "Tom",
                LastName = "Sawyer",
                AddressList = new List<Address>()
                {
                 
                    new Address()
                    {
                        AddressType = 2,
                        StreetLinel = "End",
                        StreetLine2 = "row",
                        City = "Though",
                        StateProvince = "Wi",
                        Country = "USA",
                        PostalCode = "2372"
                    },
                    new Address()
                    {
                        AddressType = 3,
                        StreetLinel = "Yaat",
                        StreetLine2 = "reet",
                        City = "Pill",
                        StateProvince = "Churn",
                        Country = "Frinch",
                        PostalCode = "17469"
                    }
                }
            };

            //Act
            var actualCustomer = customerRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expectedCustomer.EmailAddress, actualCustomer.EmailAddress);
            Assert.AreEqual(expectedCustomer.FirstName, actualCustomer.FirstName);
            Assert.AreEqual(expectedCustomer.LastName, actualCustomer.LastName);
            //Assert.AreEqual(expectedCustomer, actualCustomer);

            for(int i = 0; i < 1; i++)
            {
              
                    Assert.AreEqual(expectedCustomer.AddressList[i].AddressType, actualCustomer.AddressList[i].AddressType);
                
                
            }
        }

    }
}
