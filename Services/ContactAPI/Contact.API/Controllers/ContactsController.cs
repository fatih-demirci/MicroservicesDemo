using Contact.API.Infrastructure;
using Contact.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;
        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet("{id}")]
        public ContactDTO Get(int id) {
            return _contactService.GetContactById(id);
        }
    }
}
