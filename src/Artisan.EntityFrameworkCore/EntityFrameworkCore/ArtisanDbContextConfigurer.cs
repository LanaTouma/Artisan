using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Artisan.EntityFrameworkCore
{
    public static class ArtisanDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ArtisanDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ArtisanDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
