using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValidProduct()
        {
            //Arrange
            ProductRepository pR = new ProductRepository();
            Product expectedProduct = new Product(1)
            {
                ProductName = "Sunflowers",
                CurrentPrice = 12M,
                Description = "Some flowers"
            };

            //Act
            var actualProduct = pR.Retrieve(1);

            //Asser
            Assert.AreEqual(expectedProduct.ProductName,
                                actualProduct.ProductName);
        }
    }
}
