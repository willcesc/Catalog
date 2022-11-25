namespace WebApi.Helpers;

using Microsoft.EntityFrameworkCore;
using Catalog.Entities;
using MySql.Data.EntityFrameworkCore;

public class MySQLDbContext : DbContext
{
    public MySQLDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Item> items { get; set; }

}



