using Contact.API.Infrustructure;
using Contact.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet("GetAll")]
        public List<ContactDTO> GetAll()
        {
            return _contactService.GetContacts();
        }


        [HttpGet("{id}")]
        public ContactDTO Get(int id)
        {
            return _contactService.GetContactById(id);
        }
    }
}