using AWildSolutions.Zootah.GiftStore.API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AWildSolutions.Zootah.GiftStore.API.Endpoints;

public class HelloEndpoints : IEndpoint
{
    public void DefineServices(IServiceCollection services)
    {
        
    }

    public void DefineEndpoints(WebApplication app)
    {
        app.MapGet("/Hello", HelloWorld);
    }

    private IResult HelloWorld()
    {
        return Results.Ok("Hello World");
    }
}