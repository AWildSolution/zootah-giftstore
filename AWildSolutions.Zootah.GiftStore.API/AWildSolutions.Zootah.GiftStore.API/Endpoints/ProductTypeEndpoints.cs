using AWildSolutions.Zootah.GiftStore.API.Context.TableSets;
using AWildSolutions.Zootah.GiftStore.API.Interfaces;
using AWildSolutions.Zootah.GiftStore.API.Repositories;

namespace AWildSolutions.Zootah.GiftStore.API.Endpoints;

public class ProductTypeEndpoints : IEndpoint
{
    private IRepository<ProductType> _repo;

    public ProductTypeEndpoints(IRepository<ProductType> repo)
    {
        _repo = repo;
    }
    public void DefineServices(IServiceCollection services)
    {
        services.AddTransient<IRepository<ProductType>, ProductTypeRepository<ProductType>>();
    }

    public void DefineEndpoints(WebApplication app)
    {
        var group = app.MapGroup("ProductType");
        group.MapGet("ProductType/GetAll", GetAll)
            .Produces<IEnumerable<ProductType>>()
            .WithDescription("Get list of Product Types.  This is cached for 10 mins")
            .AllowAnonymous()
            .CacheOutput(options =>
            {
                options.Expire(TimeSpan.FromMinutes(10));
                options.Cache();
            });
    }

    private IEnumerable<ProductType> GetAll()
    {
        var list = _repo.GetAll();
        return list;
    }
}