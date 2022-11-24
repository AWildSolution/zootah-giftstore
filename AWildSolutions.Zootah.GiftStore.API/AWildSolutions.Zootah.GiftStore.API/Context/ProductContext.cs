using AWildSolutions.Zootah.GiftStore.API.Context.TableSets;
using Microsoft.EntityFrameworkCore;

namespace AWildSolutions.Zootah.GiftStore.API.Context;

public class ProductContext : DbContext
{
    public DbSet<Product> Product { get; set; }
    public DbSet<ProductType> ProductType { get; set; }
    public DbSet<ShirtSizes> ShirtSize { get; set; }

    public ProductContext()
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
    }
}