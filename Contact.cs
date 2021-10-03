using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
     public class Contact
     {
        //created instance variables
            public string FirstName { get; set; }
            public double Phone { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public double Zip { get; set; }

        //created constructor method
            public Contact(string firstName, double phone, string address, string city, string state, double zip)
            {
                this.FirstName = firstName;
                this.Phone = phone;
                this.Address = address;
                this.City = city;
                this.State = state;
                this.Zip = zip;
            }
        
     }
}
