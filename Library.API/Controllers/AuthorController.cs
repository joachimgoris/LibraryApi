using Library.Domain;
using Library.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    public class AuthorController : BaseController<Author, AuthorService>
    {
        public AuthorController(AuthorService service) : base(service) { }
    }
}
