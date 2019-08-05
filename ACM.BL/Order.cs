using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {
               
        }

        public Order(int orderId)
        {
            OrderId = OrderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Retrieve a list of all customers
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            //todo: Retrieve order data

            return new Order();
        }

        /// <summary>
        /// Saves the current order
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            //todo: Save defined order

            return true;
        }
    }
}
