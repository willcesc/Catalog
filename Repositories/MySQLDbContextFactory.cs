using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Catalog.Repositories
{
    public class MySQLDbContextFactory : IDesignTimeDbContextFactory<MySQLDbContext>
    {

        public MySQLDbContext CreateDbContext(string[] args)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 31));
            var optionsBuilder = new DbContextOptionsBuilder<MySQLDbContext>();
            optionsBuilder.UseMySql("Data Source=localhost,3306; Initial Catalog=catalog; User Id=root; Password=Root1234", serverVersion);

            return new MySQLDbContext(optionsBuilder.Options);
        }


    }
}
