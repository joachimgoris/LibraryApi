using Library.Domain;
using Microsoft.EntityFrameworkCore;

namespace Library.Services.Abstractions
{
    public interface IAuthorService<T, TContext> : IBaseService<T, TContext>
        where T : Author
        where TContext : DbContext
    { }
}