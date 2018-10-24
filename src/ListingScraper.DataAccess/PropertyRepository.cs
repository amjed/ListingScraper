using ListingScraper.Entities;
using Microsoft.EntityFrameworkCore;

namespace ListingScraper.DataAccess
{
    public class PropertyRepository: BaseRepository<Property>
    {
        public PropertyRepository(DbContext context)
        {
            DbContext = context;
        }

    }
}
