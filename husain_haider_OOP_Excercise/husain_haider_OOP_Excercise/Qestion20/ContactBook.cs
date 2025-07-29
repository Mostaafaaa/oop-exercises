namespace husain_haider_OOP_Excercise.Qestion20
{
            /*
             * Exercise 20: Create a Contact class with attributes name, phone, and
             * email. Create a ContactBook class that manages contacts with 
             * add_contact() and list_contacts().
             */
    internal class ContactBook
    {
        private List<Contact> contactList = new List<Contact>();
  
        public void add_contact(Contact contact)
        {
            
            contactList.Add(contact);
          
          

        }


        public void list_contacts()
        {
            foreach (Contact contact in contactList)
            {
                Console.WriteLine($"name-> {contact.name}\tphone-> {contact.email}\temail-> {contact.phone}");
            }

        }
    }
}
