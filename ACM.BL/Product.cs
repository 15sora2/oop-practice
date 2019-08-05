using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }
        public string ProductName { get; set; }
        public int ProductId { get; private set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }


        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName) ||
            CurrentPrice == null) isValid = false;


            return isValid;
        }

        /// <summary>
        /// Retrieve a list of all customers
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            //todo: Retrieve customer data

            return new Product();
        }

        /// <summary>
        /// Saves the current user
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //todo: Save defined customer

            return true;
        }
    }
}
