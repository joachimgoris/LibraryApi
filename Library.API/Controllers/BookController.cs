using AutoMapper;
using Library.Data;
using Library.Domain;
using Library.Services.Abstractions;

namespace Library.API.Controllers
{
    public class BookController : BaseController<Book, IBookService<Book, LibraryContext>, BookReadDto, BookCreateDto, BookModifyDto>
    {
        public BookController(IBookService<Book, LibraryContext> service, IMapper mapper) : base(service, mapper) { }
    }
}
