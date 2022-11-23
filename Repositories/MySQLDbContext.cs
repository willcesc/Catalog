using Catalog.Entities;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Repositories
{
    public class MySQLDbContext : DbContext
    {

        public MySQLDbContext(DbContextOptions<MySQLDbContext> options)
        : base(options)
        {

        }

        public DbSet<Item> items { get; set; }

    }

}