using Library.Domain;
using Microsoft.EntityFrameworkCore;

namespace Library.Services.Abstractions
{
    public interface ISeriesService<T, TContext> : IBaseService<T, TContext>
        where T : Series
        where TContext : DbContext
    { }
}
