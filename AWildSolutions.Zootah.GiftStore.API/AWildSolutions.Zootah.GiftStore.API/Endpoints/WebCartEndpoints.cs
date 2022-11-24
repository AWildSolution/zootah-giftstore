using AWildSolutions.Zootah.GiftStore.API.Interfaces;

namespace AWildSolutions.Zootah.GiftStore.API.Endpoints;

public class WebCartEndpoints : IEndpoint
{
    public void DefineServices(IServiceCollection services)
    {
        
    }

    public void DefineEndpoints(WebApplication app)
    {
        var group = app.MapGroup("WebCart");
        group.MapGet("{id:guid}", GetWebCart);
        group.MapPost("Create", CreateWebCart);
        group.MapPut("UpdateWebCart", UpdateWebCart);
        group.MapDelete("Delete", DeleteWebCart);
    }

    private void GetWebCart(Guid id)
    {
        
    }

    private void CreateWebCart()
    {
        
    }

    private void UpdateWebCart()
    {
        
    }

    private void DeleteWebCart()
    {
        
    }
}