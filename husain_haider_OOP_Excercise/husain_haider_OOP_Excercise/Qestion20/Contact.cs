using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace husain_haider_OOP_Excercise.Qestion20
{

            /*
             * Exercise 20: Create a Contact class with attributes name, phone, and
             * email. Create a ContactBook class that manages contacts with 
             * add_contact() and list_contacts().
             */
    public class Contact
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public Contact(string aName , string aEmail, string aPhone)
        {
            name = aName;
            email = aEmail;
            phone = aPhone;
            
        }
    }
}
