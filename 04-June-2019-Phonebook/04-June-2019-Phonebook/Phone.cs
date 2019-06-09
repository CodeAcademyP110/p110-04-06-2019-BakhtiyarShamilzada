using System.Collections.Generic;

namespace _04_June_2019_Phonebook
{
    public static class Phone
    {
        private readonly static List<Contact> _contacts;
        static Phone()
        {
            _contacts = new List<Contact>
            {
                new Contact { FirstName = "Bakhtiyar", LastName = "Shamilzada", Number = "051-314-34-63" },
                new Contact { FirstName = "Rashad", LastName = "Guluzade", Number = "055-614-64-93" },
                new Contact { FirstName = "Kamal", LastName = "Agayev", Number = "070-415-66-23" }
            };
        }
        public static List<Contact> GetContacts() => _contacts;
        public static void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }
        public static Contact GetContactById(string id)
        {
            foreach (var contact in _contacts)
            {
                if(contact.Id == id)
                {
                    return contact;
                }
            }
            return null;
        }
        public static Contact GetContactByName(string firstname)
        {
            foreach (var contact in _contacts)
            {
                if (contact.FirstName == firstname)
                {
                    return contact;
                }
            }
            return null;
        }
        public static Contact GetContactByNumber(string number)
        {
            foreach (var contact in _contacts)
            {
                if (contact.Number == number)
                {
                    return contact;
                }
            }
            return null;
        }
        public static bool DeleteContactById(string id)
        {
            foreach (var contact in _contacts)
            {
                if (contact.Id == id)
                {
                    _contacts.Remove(contact);
                    return true;
                }
            }
            return false;
        }
    }
}
