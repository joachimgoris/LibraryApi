using Library.Data;
using Library.Domain;
using Library.Services;
using Library.Services.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace Library.API.Extensions
{
    public static class IOC
    {
        internal static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IAuthorService<Author, LibraryContext>, AuthorService>();
            services.AddScoped<IBookService<Book, LibraryContext>, BookService>();
            services.AddScoped<IGenreService<Genre, LibraryContext>, GenreService>();
            services.AddScoped<ILanguageService<Language, LibraryContext>, LanguageService>();
            services.AddScoped<ISeriesService<Series, LibraryContext>, SeriesService>();
        }
    }
}
