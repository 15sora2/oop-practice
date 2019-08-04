using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        public string FullName
        {
            get
            {
                string fullName = $"{LastName}, {FirstName}";
                if (string.IsNullOrWhiteSpace(LastName))
                {
                    fullName = FirstName;
                }
                else if (string.IsNullOrWhiteSpace(FirstName))
                {
                    fullName = LastName;
                }
                return fullName;
            }
        }

        public static int instanceCount { get; set; }

        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName) ||
            string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Retrieve a list of all customers
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            //todo: Retrieve customer data

            return new Customer();
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
