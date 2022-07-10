using System.Net.Http;
using System.Web.Http;
using WebApplication.Models;
using WebApplication.Services;

namespace WebApplication.Controllers
{
    public class ContactController : ApiController
    {
        private ContactRepository contactRepository;
        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }

      
        public HttpResponseMessage Post(Contact contact)
        {
            this.contactRepository.SaveContact(contact);

            var response = Request.CreateResponse<Contact>(System.Net.HttpStatusCode.Created, contact);

            return response;
        }
        public Contact[] Get()
        {
            return contactRepository.GetAllContacts();
        }



    }
}
