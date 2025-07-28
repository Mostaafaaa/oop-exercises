using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /*Exercise 20: Create a Contact class with attributes name, phone, and email.
     Create a ContactBook class that manages contacts with add_contact() and list_contacts().
        * The Contact class has three attributes: name, phone, and email.
        * the ContactBook class has two methods: add_contact() and list_contacts().
        * in the add_contact() method, we create a new contact object and print its details.
        * in the list_contacts() method, we print a message indicating that we are listing contacts and then call 
        * the add_contact() method to display the contact details.

     */
    class Contact
    {
        public string Name = "Aween Ezzat";
        public String Email = "aweenezzat.gmail.com";
        public int PhoneNumber = 123456789;

       
    }
    public class ContactBook
        {
            public void AddContact()
            {
                Contact contact1 = new Contact();


                Console.WriteLine($"Name: {contact1.Name}, Email: {contact1.Email}, Phone Number: {contact1.PhoneNumber}.");

            }

            public void list_contacts()
            {
                Console.WriteLine($"List of Contacts:");
                AddContact();

            }

        }
}
    