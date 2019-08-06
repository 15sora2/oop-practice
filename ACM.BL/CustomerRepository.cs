using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            //Create the Product
            //Pass the customer Id
            Customer customer = new Customer(customerId);

            //todo: code that retrieves the defined customer

            if(customerId == 1)
            {
                customer.EmailAddress = "tsawyer@hobbition.me";
                customer.FirstName = "Tom";
                customer.LastName = "Sawyer";
            }
            return customer;
        }

        /// <summary>
        /// Saves the current customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            

            return true;
        }
    }
}
