using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CustomAbpProject.Configuration;
using CustomAbpProject.Web;

namespace CustomAbpProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CustomAbpProjectDbContextFactory : IDesignTimeDbContextFactory<CustomAbpProjectDbContext>
    {
        public CustomAbpProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CustomAbpProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            CustomAbpProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CustomAbpProjectConsts.ConnectionStringName));

            return new CustomAbpProjectDbContext(builder.Options);
        }
    }
}
