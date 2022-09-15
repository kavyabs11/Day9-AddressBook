using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Address
    {
        List<Contact> add_book = new List<Contact>();          //created an address book list of Contacts class type
        public void create()
        {
            Contact contact = new Contact();                    //created an object of the Contacts class and added Contacts details
            Console.WriteLine("Enter your first name");
            contact.first_name = Console.ReadLine();
            Console.WriteLine("Enter your second name");
            contact.s_name = Console.ReadLine();
            Console.WriteLine("Enter your address");
            contact.address = Console.ReadLine();
            Console.WriteLine("Enter your city");
            contact.city = Console.ReadLine();
            Console.WriteLine("Enter your state");
            contact.state = Console.ReadLine();
            Console.WriteLine("Enter your zip code");
            contact.zip = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your phone number");
            contact.phone_no = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your email");
            contact.email = Console.ReadLine();
            add_book.Add(contact);
        }
        public void display()               //displaying details of each conatact
        {
            foreach (var data in add_book)
            {
                Console.WriteLine("Contacts stored_________");
                Console.WriteLine($"Contacts No. - {data}");
                Console.WriteLine($"Name - {data.first_name} {data.s_name}");
                Console.WriteLine($"Address - {data.address}");
                Console.WriteLine($"City- {data.city}");
                Console.WriteLine($"State - {data.state}");
                Console.WriteLine($"Zip - {data.zip}");
                Console.WriteLine($"Phone no. - {data.phone_no}");
                Console.WriteLine($"Email - {data.email}\n");
            }
        }
    }
}