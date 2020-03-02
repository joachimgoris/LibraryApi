using Library.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Services.Abstractions
{
    public class BaseService<T, TContext> : IBaseService<T, TContext>
        where T : Entity
        where TContext : DbContext
    {
        public TContext Context { get; set; }

        public BaseService(TContext context)
        {
            Context = context;
        }

        public virtual void Delete(string entityId)
        {
            T entity = Context.Find<T>(entityId);
            Context.Remove(entity);
        }

        public virtual async Task DeleteAsync(string entityId)
        {
            T entity = await Context.FindAsync<T>(entityId);
            Context.Remove(entity);
        }

        public virtual T Get(string entityId)
        {
            return Context.Find<T>(entityId);
        }

        public virtual async Task<T> GetAsync(string entityId)
        {
            return await Context.FindAsync<T>(entityId);
        }

        public virtual T Insert(T entity)
        {
            Context.Add(entity);
            return entity;
        }

        public virtual async Task<T> InsertAsync(T entity)
        {
            await Context.AddAsync(entity);
            return entity;
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await Context.SaveChangesAsync();
        }

        public virtual T Update(T entity)
        {
            Context.Update(entity);
            return entity;
        }

        public IQueryable<T> GetAll()
        {
            return Context.Set<T>().AsNoTracking();
        }
    }
}
