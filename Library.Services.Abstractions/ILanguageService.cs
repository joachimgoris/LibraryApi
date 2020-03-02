using Library.Domain;
using Microsoft.EntityFrameworkCore;

namespace Library.Services.Abstractions
{
    public interface ILanguageService<T, TContext>  : IBaseService<T,TContext>
        where T : Language
        where TContext : DbContext
    { }
}
