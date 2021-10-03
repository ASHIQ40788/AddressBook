using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    class ContactDetails
    {
        List<Contact> contactlist = new List<Contact>();
        public void AddContact()
        {

            //adding contacts  details.
            Console.WriteLine("Enter your first Name");
            var FirstName = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            var Phone = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Address");
            var Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            var City = Console.ReadLine();
            Console.WriteLine("Enter State");
            var State = Console.ReadLine();
            Console.WriteLine("Enter Zip Code");
            var Zip = int.Parse(Console.ReadLine());
            Contact _contact = new Contact(FirstName, Phone, Address, City, State, Zip);
            contactlist.Add(_contact);
        }

        //Created method to display contact details
        public void Display()
        {
            foreach (Contact con in contactlist)
            {
                Console.WriteLine(con.FirstName + "  " + con.Phone + "  " + con.Address + "  " + con.City + "  " + con.State + "  " + con.Zip);
            }
        }
    }
}
