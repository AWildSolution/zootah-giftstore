using AWildSolutions.Zootah.GiftStore.API.Interfaces;

namespace AWildSolutions.Zootah.GiftStore.API.Endpoints;

public class ProductsEndpoints : IEndpoint
{
    public void DefineServices(IServiceCollection services)
    {
        
    }

    public void DefineEndpoints(WebApplication app)
    {
        var group = app.MapGroup("Products");
        group.MapGet("GetAll", GetAll);
        group.MapGet("{id:guid}", Get);
    }

    private void GetAll()
    {
        
    }

    private void Get(Guid id)
    {
        
    }
}