using Contact.API.Models;
using System.Collections.Generic;

namespace Contact.API.Infrustructure
{
    public interface IContactService
    {
        public ContactDTO GetContactById(int Id);

        public List<ContactDTO> GetContacts();
    }
}