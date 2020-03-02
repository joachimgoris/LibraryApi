using Library.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Services.Abstractions
{
    public interface IBaseService<T, TContext>
        where T : Entity
        where TContext : DbContext
    {
        TContext Context { get; set; }

        Task<T> InsertAsync(T entity);

        T Insert(T entity);

        Task<T> GetAsync(string entityId);

        T Get(string entityId);

        T Update(T entity);

        Task DeleteAsync(string entityId);

        void Delete(string entityId);

        IQueryable<T> GetAll();

        Task SaveAsync();

        void Save();
    }
}
