using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if(addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLinel = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Milwaukee";
                address.StateProvince = "Wi";
                address.Country = "USA";
                address.PostalCode = "70872";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(2)
            {
                AddressType = 2,
                StreetLinel = "End",
                StreetLine2 = "row",
                City = "Though",
                StateProvince = "Wi",
                Country = "USA",
                PostalCode = "2372"
            };
            addressList.Add(address);

            address = new Address(3)
            {
                AddressType = 3,
                StreetLinel = "Yaat",
                StreetLine2 = "reet",
                City = "Pill",
                StateProvince = "Churn",
                Country = "Frinch",
                PostalCode = "17469"
            };
            addressList.Add(address);

            return addressList;

        }

            public bool Save()
        {
            return true;
        }
    }
}
