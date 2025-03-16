using Phonebook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Domain.Interfaces
{
    public interface IContactRepository
    {
        public void AddContact(Contact contact);
        public void UpdateContact(Contact contact);
        public void DeleteContact(int id);
        public Contact GetContactById(int id);
        public List<Contact> GetAllContacts();
        public void SaveContact();
        public List<Contact> SearchContacts(string searchQuery);
    }
}
