using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
            {
                //Create the Product
                //Pass the customer Id
                Product product = new Product(productId);

                //todo: code that retrieves the defined customer

                if (productId == 1)
                {
                    product.ProductName = "Sunflowers";
                    product.CurrentPrice = 12M;
                    product.Description = "Some flowers";
                }
                return product;
            }

        public bool Save(Product product)
        {


            return true;
        }

    }

    


}
