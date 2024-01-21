using Microsoft.EntityFrameworkCore;
using ShopExpressTest.Interfaces.Data;
using ShopExpressTest.Entities;
using System.Reflection;

namespace ShopExpressTest.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<UserTask> Tasks => Set<UserTask>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
