using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveValidOrder()
        {
            //Arrange
            OrderRepository oR = new OrderRepository();
            Order expectedOrder = new Order(1)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                                                        new TimeSpan(7, 0, 0))

            };

            //Act
            var actualOrder = oR.Retrieve(1);

            //Asser
            Assert.AreEqual(expectedOrder.OrderDate,
                                actualOrder.OrderDate);
        }
    }
}
