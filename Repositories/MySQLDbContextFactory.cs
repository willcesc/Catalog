namespace WebApi.Helpers;

using Microsoft.EntityFrameworkCore;
using Catalog.Entities;
using MySql.Data.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class MySQLDbContextFactory : IDesignTimeDbContextFactory<MySQLDbContext>
{

    public MySQLDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<MySQLDbContext>();
        optionsBuilder.UseMySQL("Data Source=localhost,3306; Initial Catalog=catalog; User Id=root; Password=Root1234");

        return new MySQLDbContext(optionsBuilder.Options);
    }


}
