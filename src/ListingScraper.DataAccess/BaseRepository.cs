using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingScraper.Entities;
using Microsoft.EntityFrameworkCore;

namespace ListingScraper.DataAccess
{
    public abstract class BaseRepository<T>:IRepository<T> where T : EntityBase
    {
        public DbContext DbContext { get; protected set; }
        public IEnumerable<T> GetAll()
        {
            return DbContext.Set<T>().AsEnumerable();
        }

        public virtual async Task<T> GetById(int id)
        {
            return await DbContext.Set<T>().FindAsync(id).ConfigureAwait(false);
        }

        public virtual async Task Create(T entity)
        {
            entity.CreatedDate = DateTime.UtcNow;
            DbContext.Set<T>().Add(entity);
            await DbContext.SaveChangesAsync().ConfigureAwait(false);
        }

        public virtual async Task Update(T entity)
        {
            entity.UpdatedOn = DateTime.UtcNow;
            DbContext.Set<T>().Update(entity);

            await DbContext.SaveChangesAsync().ConfigureAwait(false);
        }

        public virtual async Task<bool> Delete(int id)
        {
            var entity = await DbContext.Set<T>().FindAsync(id).ConfigureAwait(false);
            DbContext.Set<T>().Remove(entity);
            var result = await DbContext.SaveChangesAsync().ConfigureAwait(false);
            return result > 0;
        }
    }
}
