using AWildSolutions.Zootah.GiftStore.API.Interfaces;

namespace AWildSolutions.Zootah.GiftStore.API.Endpoints;

public class WebCartEndpoints : IEndpoint
{
    public void DefineServices(IServiceCollection services)
    {
        
    }

    public void DefineEndpoints(WebApplication app)
    {
        app.MapGet("WebCart/{id:guid}", GetWebCart);
        app.MapPost("WebCart/Create", CreateWebCart);
        app.MapPut("WebCart/UpdateWebCart", UpdateWebCart);
        app.MapDelete("WebCart/Delete", DeleteWebCart);
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