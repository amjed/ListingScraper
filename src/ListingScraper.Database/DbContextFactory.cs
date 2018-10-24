using ListingScraper.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ListingScraper.Database
{
    public class DbContextFactory : IDesignTimeDbContextFactory<ListingScraperContext>
    {
        private const string _connStrLocal = "Data Source=ListingScraper.db";
        public ListingScraperContext CreateDbContext(string[] args)
        {
            var dbContextOptionsBuilder = new DbContextOptionsBuilder<ListingScraperContext>();
            dbContextOptionsBuilder.UseSqlite(_connStrLocal);
            return new ListingScraperContext(dbContextOptionsBuilder.Options);
        }
    }
}