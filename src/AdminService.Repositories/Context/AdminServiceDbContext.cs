using Microsoft.EntityFrameworkCore;
using AdminService.Repositories.Configurations;
using AdminService.Repositories.Entities;

namespace AdminService.Repositories.Context;

/// <summary>
/// Service-specific DbContext. Strictly isolated to this service's own database.
/// Other services must NEVER connect to this DbContext.
/// </summary>
public class AdminServiceDbContext : DbContext
{
    public AdminServiceDbContext(DbContextOptions<AdminServiceDbContext> options) : base(options)
    {
    }

    public DbSet<SampleItem> SampleItems => Set<SampleItem>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new SampleItemConfiguration());
    }
}
