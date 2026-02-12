using Microsoft.EntityFrameworkCore;
using Ecommerce.Api.Domain.Entities;

namespace Ecommerce.Api.Infrastructure.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected AppDbContext()
        {
        }

        public DbSet<User> Users { get; set; }

    }
}
