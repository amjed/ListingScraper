using System;
using ListingScraper.Database;
using Microsoft.EntityFrameworkCore;

namespace ListingScraper.DataAccess.Tests
{
    public class BaseTestFixture:IDisposable
    {
        public DbContext DbContext { get; set; }
        public BaseTestFixture()
        {
            DbContext = new DbContextFactory().CreateDbContext(new string[] { });
            DbContext.Database.EnsureCreated();
        }

        public void Dispose()
        {
            DbContext.Database.CloseConnection();
            DbContext.Database.EnsureDeleted();
        }
    }
}
