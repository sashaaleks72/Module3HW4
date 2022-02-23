using System;
using System.Linq;

namespace Module3HW4
{
    public class Starter
    {
        public void Run()
        {
            var logic = new Delegates(2, 6);

            logic.SumOfResults((someStr) =>
            {
                throw new Exception(someStr);
            });

            Console.WriteLine();

            var contacts = new ContactContainer();
            contacts.InitDefault();

            foreach (var item in contacts.Contacts)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            Contact? firstContact = contacts.Contacts.FirstOrDefault(contact => contact.FirstName == "Aleksandr");
            Console.WriteLine(firstContact);
            Console.WriteLine();

            var returnedList = contacts.Contacts.Where(cont => cont.FirstName.StartsWith('V')).Select(c => $"{c.FirstName} {c.LastName}").ToList();

            foreach (var item in returnedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine(contacts.Contacts.ElementAt(2));
            Console.WriteLine();

            var orderedContactListByName = contacts.Contacts.OrderBy(c => c.FirstName).ToList();

            Console.WriteLine("Ordered contact list by first name: ");
            foreach (var item in orderedContactListByName)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine(contacts.Contacts.Any(c => c.FirstName == "Aleksandr"));
        }
    }
}
