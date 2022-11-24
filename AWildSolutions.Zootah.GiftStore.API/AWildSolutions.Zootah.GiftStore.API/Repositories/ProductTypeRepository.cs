using AWildSolutions.Zootah.GiftStore.API.Context;
using AWildSolutions.Zootah.GiftStore.API.Context.TableSets;
using AWildSolutions.Zootah.GiftStore.API.Interfaces;

namespace AWildSolutions.Zootah.GiftStore.API.Repositories;

public class ProductTypeRepository<T> : MainRepository<T> where T : class
{
    public ProductTypeRepository(ProductContext context)
    {
        Context = context;
        DbSet = context.Set<T>();
    }
}