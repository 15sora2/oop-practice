using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        /// <summary>
        /// Retrieve a customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            //Create the instance of the Customer
            //Pass the customer Id
            Customer customer = new Customer(customerId);

            //code that retrieves the defined customer
            if(customerId == 1)
            {
                customer.EmailAddress = "tsawyer@hobbition.me";
                customer.FirstName = "Tom";
                customer.LastName = "Sawyer";
                customer.AddressList = addressRepository.RetrieveByCustomerId(1).
                    ToList();

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
            
            //todo: code that saves the customer

            return true;
        }
    }
}
