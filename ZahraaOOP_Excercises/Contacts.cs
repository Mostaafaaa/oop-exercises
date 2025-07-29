using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZahraaOOP_Excercises
{
    /*Exercise 20: Create a Contact class with attributes name, phone, and email. 
     * Create a ContactBook class that manages contacts with add_contact() and list_contacts().*/
    internal class Contacts
    {
        protected string Name { get; set; }
        protected string Phone { get; set; }
        protected string Email { get; set; }
    }

    internal class ContactBook: Contacts
    {
        private List<Contacts> contacts = new List<Contacts>();

        public void AddContact(Contacts contact)
        {
            contacts.Add(contact);
        }

        public void ListContacts()
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Name: {Name}, Phone: {Phone}, Email: {Email}");
            }
        }
    }
}
