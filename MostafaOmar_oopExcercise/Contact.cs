using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MostafaOmar_oopExcercise
{
    //Exercise 20:
    //Create a Contact class with attributes name, phone, and email.
    //Create a ContactBook class that manages contacts with add_contact() and list_contacts().

    internal class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Contact(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"Email: {Email}");
        }
    }

    class ContactBook
    {
        List<Contact> contacts = new List<Contact>();

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
            Console.WriteLine($"Contact '{contact.Name}' added successfully.");
        }

        public void ListContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("Contact book is empty.");
            }

            Console.WriteLine("---- Contact List ----");
            foreach (Contact contact in contacts)
            {
                contact.DisplayInfo();
                Console.WriteLine("---------------------");
            }
        }
    }

}
    