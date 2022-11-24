using AWildSolutions.Zootah.GiftStore.API.Context.TableSets;
using AWildSolutions.Zootah.GiftStore.API.Interfaces;
using AWildSolutions.Zootah.GiftStore.API.Repositories;

namespace AWildSolutions.Zootah.GiftStore.API.Endpoints;

public class ProductTypeEndpoints : IEndpoint
{
    private IRepository<ProductType> _repo;
    public void DefineServices(IServiceCollection services)
    {
        services.AddTransient<IRepository<ProductType>, ProductTypeRepository<ProductType>>();
    }

    public void DefineEndpoints(WebApplication app)
    {
        app.MapGet("ProductType/GetAll", GetAll);
    }

    private IEnumerable<ProductType> GetAll()
    {
        var list = _repo.GetAll();
        return list;
    }
}