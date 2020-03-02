using Library.Data;
using Library.Domain;
using Library.Services.Abstractions;

namespace Library.Services
{
    public class LanguageService : BaseService<Language, LibraryContext>, ILanguageService<Language, LibraryContext>
    {
        public LanguageService(LibraryContext context) : base(context) { }
    }
}
