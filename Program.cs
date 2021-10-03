using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address book program");

            //UC2-Add Contact Details
            ContactDetails contactDetails = new ContactDetails();
            contactDetails.AddContact();
        }
    }
}
