using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CustomAbpProject.Authorization.Roles;
using CustomAbpProject.Authorization.Users;
using CustomAbpProject.MultiTenancy;

namespace CustomAbpProject.EntityFrameworkCore
{
    public class CustomAbpProjectDbContext : AbpZeroDbContext<Tenant, Role, User, CustomAbpProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CustomAbpProjectDbContext(DbContextOptions<CustomAbpProjectDbContext> options)
            : base(options)
        {
        }
    }
}
