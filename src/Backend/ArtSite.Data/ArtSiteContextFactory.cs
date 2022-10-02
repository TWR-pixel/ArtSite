using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ArtSite.Data;

public class ArtSiteContextFactory : IDesignTimeDbContextFactory<ArtSiteDbContext>
{
    public ArtSiteDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ArtSiteDbContext>();

        // получаем конфигурацию из файла appsettings.json
        var builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory());
        builder.AddJsonFile("appsettings.json");

        var config = builder.Build();

        // получаем строку подключения из файла appsettings.json
        var connectionString = config.GetConnectionString("DefaultConnection");

        optionsBuilder.UseSqlite(connectionString);

        return new ArtSiteDbContext(connectionString);
    }
}
