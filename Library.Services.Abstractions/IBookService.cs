using Library.Domain;
using Microsoft.EntityFrameworkCore;

namespace Library.Services.Abstractions
{
    public interface IBookService<T, TContext> : IBaseService<T, TContext>
        where T : Book
        where TContext : DbContext 
    { }
}
