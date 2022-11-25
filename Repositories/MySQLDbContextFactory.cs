using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace Catalog.Repositories
{
    public class MySQLDbContextFactory : IDesignTimeDbContextFactory<MySQLDbContext>
    {

        public MySQLDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MySQLDbContext>();
            optionsBuilder.UseMySQL("Data Source=localhost,3306; Initial Catalog=catalog; User Id=root; Password=Root1234");

            return new MySQLDbContext(optionsBuilder.Options);
        }


    }
}
