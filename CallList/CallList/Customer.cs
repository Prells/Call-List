using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallList
{
    public class Customer
    {
        public Customer() { }

       

        public String name { get; set; }

        public String phoneNumber { get; set; }

        public List<String> sets { get; set; }

        public String itemHeld { get; set; }

        public String dateCalled { get; set; }

        public String itemPickedUp { get; set; }

        public String datePickedUp { get;set; }

        public String notes { get; set; }

    }
}
