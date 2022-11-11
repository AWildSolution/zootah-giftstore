using AWildSolutions.Zootah.GiftStore.API.Context.TableSets;
using AWildSolutions.Zootah.GiftStore.API.Interfaces;

namespace AWildSolutions.Zootah.GiftStore.API.Endpoints;

public class ProductTypeEndpoints : IEndpoint
{
    private 
    public void DefineServices(IServiceCollection services)
    {
        
    }

    public void DefineEndpoints(WebApplication app)
    {
        app.MapGet("ProductType/GetAll", GetAll);
    }

    private List<ProductType> GetAll()
    {
        
    }
}