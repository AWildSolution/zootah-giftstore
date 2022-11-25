using AWildSolutions.Zootah.GiftStore.API.Context.TableSets;
using AWildSolutions.Zootah.GiftStore.API.Interfaces;
using AWildSolutions.Zootah.GiftStore.API.Repositories;

namespace AWildSolutions.Zootah.GiftStore.API.Endpoints;

public class ProductTypeEndpoints : IEndpoint
{
    public void DefineServices(IServiceCollection services)
    {
        services.AddTransient<IRepository<ProductType>, ProductTypeRepository<ProductType>>();
    }

    public void DefineEndpoints(WebApplication app)
    {
        RouteGroupBuilder group = app.MapGroup("ProductType");
        group.MapGet("GetAll", GetAll)
            .Produces<IEnumerable<ProductType>>()
            .WithDescription("Get list of Product Types.  This is cached for 10 mins")
            .AllowAnonymous()
            .CacheOutput(options =>
            {
                options.Expire(TimeSpan.FromMinutes(10));
                options.Cache();
            });
    }

    private IEnumerable<ProductType> GetAll(IRepository<ProductType> repo)
    {
        IEnumerable<ProductType> list = repo.GetAll();
        return list;
    }
}