using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BoxEco.Data
{
    public class BoxEcoContextFactory : IDesignTimeDbContextFactory<BoxEcoContext>
    {
        public BoxEcoContext CreateDbContext(string[] args) 
        { 
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<BoxEcoContext>();
            builder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            return new BoxEcoContext(builder.Options);
        }
    }
}
