using ListingScraper.Entities;
using Microsoft.EntityFrameworkCore;

namespace ListingScraper.Database
{
    public class ListingScraperContext : DbContext
    {
        public ListingScraperContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Property> Properties { get; set; }
        public DbSet<ScrapeRequests> ScrapeRequests { get; set; }
        public DbSet<PageDownloadData> PageDownloadData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}