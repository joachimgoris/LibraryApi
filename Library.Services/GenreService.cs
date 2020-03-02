using Library.Data;
using Library.Domain;
using Library.Services.Abstractions;

namespace Library.Services
{
    public class GenreService : BaseService<Genre, LibraryContext>, IGenreService<Genre, LibraryContext>
    {
        public GenreService(LibraryContext context) : base(context) { }
    }
}
