using Library.Data;
using Library.Domain;
using Library.Services.Abstractions;

namespace Library.Services
{
    public class AuthorService : BaseService<Author, LibraryContext>, IAuthorService<Author, LibraryContext>
    {
        public AuthorService(LibraryContext context) : base(context) { }
    }
}
