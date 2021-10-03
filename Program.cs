using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    class Program
    {
        //Created a dictionary for to store multiple contacts by using the key.
        public static Dictionary<string, LinkedList<Contact>> addressBook = new Dictionary<string, LinkedList<Contact>>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book management");
            Console.WriteLine("Enter the no. of address books you want to add: ");
            int NumberofAddressBook = Convert.ToInt32(Console.ReadLine());
            int NumberofBooks = 0;
            while (NumberofBooks < NumberofAddressBook)
            {
                Console.WriteLine("Enter the name of the address book: ");
                string bookName = Console.ReadLine();
                ContactDetails person = new ContactDetails();
                Console.WriteLine("Enter the no of contacts you want to add in the address book: ");
                int contactNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Choose any option to perform:\n 1.Adding a new contact \n 2.Editing a existing contact \n 3.Deleting existing contact \n 4.Exit from the process");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        while (contactNum > 0)
                        {
                            Console.WriteLine("Enter the details of contact to be added: ");
                            person.AddContact();
                            contactNum = -1;
                            person.Disply();
                        }
                        break;
                    case 2:
                        person.EditContact();
                        person.Disply();
                        Console.WriteLine("Enter any key to continue");
                        break;
                    case 3:
                        person.DeleteContact();
                        person.Disply();
                        Console.WriteLine("Enter any key to continue");
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;
                }

                //UC2-Add Contact Details
                //ContactDetails contactDetails = new ContactDetails();
                ////UC5-Adding Multiple Contact Details
                //contactDetails.AddContact();

                ////UC3-Editing Contact Details
                //contactDetails.EditContact();

                ////uc4-Deleting Contact Details
                //contactDetails.DeleteContact();
                //check if added address book is exist or not, using method of contains key, if not add that
                if (addressBook.ContainsKey(bookName))
                {
                    Console.WriteLine("Address book is already exists");
                    return;
                }
                else
                {
                    addressBook.Add(bookName, person.personDetails);
                }
                NumberofBooks++;

                foreach (KeyValuePair<string, LinkedList<Contact>> item in addressBook)
                {
                    Console.WriteLine("Existing address books are {0}", item.Key);

                }
            }
        }
    }
}
