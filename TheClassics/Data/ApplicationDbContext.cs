using Microsoft.EntityFrameworkCore;
using TheClassics.Models;

namespace TheClassics.Data
{
    /// <summary>
    /// EF Core database context for TheClassics application.
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User>          Users          { get; set; }
        public DbSet<Order>         Orders         { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }
    }
}