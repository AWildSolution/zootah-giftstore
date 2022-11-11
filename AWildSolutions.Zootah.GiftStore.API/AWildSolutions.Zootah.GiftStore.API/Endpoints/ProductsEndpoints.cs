using AWildSolutions.Zootah.GiftStore.API.Interfaces;

namespace AWildSolutions.Zootah.GiftStore.API.Endpoints;

public class ProductsEndpoints : IEndpoint
{
    public void DefineServices(IServiceCollection services)
    {
        
    }

    public void DefineEndpoints(WebApplication app)
    {
        app.MapGet("Products/GetAll", GetAll);
        app.MapGet("Products/{id:guid}", Get);
    }

    private void GetAll()
    {
        
    }

    private void Get(Guid id)
    {
        
    }
}