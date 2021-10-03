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
        //UC6.
        public LinkedList<Contact> personDetails = new LinkedList<Contact>();
        public void AddContact()
        {

            //adding contacts  details.
            Console.WriteLine("Enter your first Name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            double Phone = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter Address");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            string City = Console.ReadLine();
            Console.WriteLine("Enter State");
            string State = Console.ReadLine();
            Console.WriteLine("Enter Zip Code");
            double Zip = int.Parse(Console.ReadLine());
            Contact _contact = new Contact(FirstName, Phone, Address, City, State, Zip);
            contactlist.Add(_contact);
        }

        //Created method to display contact details
        public void Display()
        {
            foreach (Contact contact in contactlist)
            {
                Console.WriteLine(contact.FirstName + "  " + contact.Phone + "  " + contact.Address + "  " + contact.City + "  " + contact.State + "  " + contact.Zip);
            }
        }
        //UC3-Edit contact details.
        public void EditContact()
        {

            Console.WriteLine(" enter firstName to modify contact details of a person ");
            string UserFirstname = Console.ReadLine();
            foreach (Contact contact in contactlist)
            {
                // Console.WriteLine(contact.FirstName + "  " + contact.Phone + "  " + contact.Address + "  " + contact.City + "  " + contact.State + "  " + contact.Zip);
                if (contact.FirstName.Equals(UserFirstname))
                {
                    Console.WriteLine("what data u want to edit,press first character only  of that field");
                    char userinput = char.Parse(Console.ReadLine());
                    switch (userinput)
                    {
                        case 'a':
                            Console.WriteLine(" enter address");
                            contact.Address = Console.ReadLine();
                            Console.WriteLine(" edited Adress" + contact.Address);
                            break;
                        case 'p':
                            Console.WriteLine(" enter Phone");
                            contact.Phone = int.Parse(Console.ReadLine());
                            Console.WriteLine(" edited Adress" + contact.Phone);
                            break;
                        case 'f':
                            Console.WriteLine(" enter firstname");
                            contact.FirstName = Console.ReadLine();
                            Console.WriteLine(" edited Adress" + contact.FirstName);
                            break;
                        case 'c':
                            Console.WriteLine(" enter city");
                            contact.City = Console.ReadLine();
                            Console.WriteLine(" edited Adress" + contact.City);
                            break;
                        case 's':
                            Console.WriteLine(" enter state");
                            contact.State = Console.ReadLine();
                            Console.WriteLine(" edited Adress" + contact.State);
                            break;
                        case 'z':
                            Console.WriteLine(" enter address");
                            contact.Zip = int.Parse(Console.ReadLine());
                            Console.WriteLine(" edited Adress" + contact.Zip);
                            break;

                        default:
                            Console.WriteLine("wrong input ");
                            break;
                    }
                }
            }
        }

        //UC4-deleting contact details
        public void DeleteContact()
        {

            Console.WriteLine(" enter firstName to delete the contact ");
            string UserFirstname = Console.ReadLine();
            foreach (Contact contact in contactlist)
            {
                // Console.WriteLine(contact.FirstName + "  " + contact.Phone + "  " + contact.Address + "  " + contact.City + "  " + contact.State + "  " + contact.Zip);
                if (contact.FirstName.Equals(UserFirstname))
                {
                    contactlist.Remove(contact);
                    break;
                }

            }
        }

        //UC6
        //Printing/Displaying the address book details 
        public void Disply()
        {
            if (personDetails.Count == 0)
            {
                Console.WriteLine("Address Book is empty.");
                return;
            }
            else
            {
                foreach (Contact person in personDetails)
                {
                    Console.WriteLine("Address book details");
                    Console.WriteLine("enter your  First Name:" + person.FirstName);
                    Console.WriteLine("enter your Address:" + person.Address);
                    Console.WriteLine("enter your City:" + person.City);
                    Console.WriteLine("enter your Phone Number:" + person.Phone);
                    Console.WriteLine("enter your State:" + person.State);
                    Console.WriteLine("enter your Zip:" + person.Zip);
                   
                }
            }
        }


    }

}
