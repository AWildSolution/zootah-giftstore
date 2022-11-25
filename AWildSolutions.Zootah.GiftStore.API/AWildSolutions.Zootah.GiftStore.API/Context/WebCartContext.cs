using AWildSolutions.Zootah.GiftStore.API.Context.TableSets;
using Microsoft.EntityFrameworkCore;

namespace AWildSolutions.Zootah.GiftStore.API.Context;

public class WebCartContext :DbContext
{
    public DbSet<WebCart> WebCart { get; set; }

    public WebCartContext(DbContextOptions<WebCartContext> options) : base(options)
    {
        
    }
    
    
}