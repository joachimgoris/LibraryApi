using Library.Data;
using Library.Domain;
using Library.Services.Abstractions;

namespace Library.Services
{
    public class BookService : BaseService<Book, LibraryContext>, IBookService<Book, LibraryContext>
    {
        public BookService(LibraryContext context) : base(context) { }
    }
}
