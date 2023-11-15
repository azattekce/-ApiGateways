using Contact.API.Infrustructure;
using Contact.API.Models;
using System.Collections.Generic;

namespace Contact.API.Services
{
    public class ContactService : IContactService
    {
        public ContactDTO GetContactById(int Id)
        {
            return new ContactDTO
            {
                Id = 1,
                FirstName = "Şerif",
                LastName = "Aydın"
            };
        }


        public List<ContactDTO> GetContacts()
        {
            return
               new List<ContactDTO> { 
                new ContactDTO{Id = 1, FirstName = "AZAT", LastName = "TEKÇE"},
                 new ContactDTO{Id = 2, FirstName = "Özge", LastName = "TEKÇE"},
                  new ContactDTO{Id = 3, FirstName = "Lina", LastName = "TEKÇE"},
                 };
            
               
             
        }
    }
}