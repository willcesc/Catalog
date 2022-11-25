using Microsoft.EntityFrameworkCore;
using Catalog.Entities;
namespace Catalog.Repositories
{
    public class MySQLDbContext : DbContext
    {
        public MySQLDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Item> items { get; set; }

    }

}

