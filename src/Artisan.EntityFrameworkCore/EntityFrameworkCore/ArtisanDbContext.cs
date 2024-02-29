using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Artisan.Authorization.Roles;
using Artisan.Authorization.Users;
using Artisan.MultiTenancy;

namespace Artisan.EntityFrameworkCore
{
    public class ArtisanDbContext : AbpZeroDbContext<Tenant, Role, User, ArtisanDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ArtisanDbContext(DbContextOptions<ArtisanDbContext> options)
            : base(options)
        {
        }
    }
}
