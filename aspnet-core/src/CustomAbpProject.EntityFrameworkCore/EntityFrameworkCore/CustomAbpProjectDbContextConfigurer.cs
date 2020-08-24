using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CustomAbpProject.EntityFrameworkCore
{
    public static class CustomAbpProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CustomAbpProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CustomAbpProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
