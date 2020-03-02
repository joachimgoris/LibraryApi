using Library.Domain;
using Microsoft.EntityFrameworkCore;

namespace Library.Services.Abstractions
{
    public interface IGenreService<T, TContext> : IBaseService<T, TContext>
        where T : Genre
        where TContext : DbContext 
    { }
}
