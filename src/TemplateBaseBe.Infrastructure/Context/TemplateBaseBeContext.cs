using Microsoft.EntityFrameworkCore;
using TemplateBaseBe.Domain.Entities;

namespace TemplateBaseBe.Data.Context;

public class TemplateBaseBeContext : DbContext
{
    public TemplateBaseBeContext(DbContextOptions<TemplateBaseBeContext> options) : base(options)
    {

    }

    #region DbSets
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    #endregion

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(TemplateBaseBeContext).Assembly);
    }
}
