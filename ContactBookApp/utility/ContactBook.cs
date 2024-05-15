using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactBookApp.model;

namespace ContactBookApp.utility
{
    internal class ContactBook
    {

        Dictionary<string, Contact> newContact = new Dictionary<string, Contact>();

        public void AddContact(Contact contact)
        {
            newContact.Add(contact.Name, contact);
        }
        public void RemoveContact(string name)
        {
            newContact.Remove(name);
        }
        public void GetContact(string name)
        {
            if (newContact.ContainsKey(name))
            {
                newContact.ContainsKey(name);
            }
            else
            {
                Console.WriteLine("Contact does not exist");
            }
        }
        public void GetAllContact()
        {
            foreach (var contact in newContact.Values)
            {
                Console.WriteLine($"Name :{contact.Name} and Phone Number {contact.PhoneNumber}");
            }
        }



    }
}
