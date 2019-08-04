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
        public string FullName {
            get
            {
                string fullName = $"{LastName}, {FirstName}";
                if (string.IsNullOrWhiteSpace(LastName))
                {
                    fullName = FirstName;
                } else if(string.IsNullOrWhiteSpace(FirstName)){
                    fullName = LastName;
                }
                return fullName;
            }
        }

        public static int instanceCount { get; set; }
    }
}
