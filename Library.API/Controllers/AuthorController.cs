using AutoMapper;
using Library.Data;
using Library.Domain;
using Library.Dto.Author;
using Library.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    public class AuthorController : BaseController<Author, IAuthorService<Author, LibraryContext>, AuthorReadDto, AuthorCreateDto, AuthorModifyDto>
    {
        public AuthorController(IAuthorService<Author, LibraryContext> service, IMapper mapper) : base(service, mapper) { }
    }
}