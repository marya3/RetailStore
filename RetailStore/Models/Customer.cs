using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailStore.Models
{
    public class Customer
    {
        public int customerId { get; set; }
        public String firstName { get; set; }

        public String lastName { get; set; }
        public String street { get; set; }
        public int zipCode { get; set; }
        public String city { get; set; }
        public String email { get; set; }
    }
}
