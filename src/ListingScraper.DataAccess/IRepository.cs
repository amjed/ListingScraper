using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ListingScraper.DataAccess
{
    public interface IRepository<T> where T : class
    {
        DbContext DbContext { get; }
        IEnumerable<T> GetAll();
        Task<T> GetById(int id);
        Task Create(T entity);
        Task Update(T entity);
        Task<bool> Delete(int id);
    }
}
