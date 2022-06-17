using System.Collections.Generic;

namespace Module3HW4
{
    public class ContactContainer
    {
        public ContactContainer()
        {
            Contacts = new List<Contact>();
        }

        public List<Contact> Contacts { get; set; }

        public void InitDefault()
        {
            Contacts.Add(new Contact("Vladimir", "Troyanov", "+380501234567"));
            Contacts.Add(new Contact("Aleksei", "Petrov", "+380675674567"));
            Contacts.Add(new Contact("Maksim", "Dronov", "+380959874567"));
            Contacts.Add(new Contact("Aleksandr", "Seleznev", "+380631234567"));
            Contacts.Add(new Contact("Vladislav", "Bagach", "+380681287567"));
        }
    }
}
