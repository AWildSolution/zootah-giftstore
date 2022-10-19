using AWildSolutions.Zootah.GiftStore.API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AWildSolutions.Zootah.GiftStore.API.Endpoints;

public class HelloEndpoints : IEndpoint
{
    public void DefineServices(IServiceCollection services)
    {
        
    }

    /// <summary>
    /// This is where your endpoints are going to be defined. You can either pass a function like the hello world or
    /// do it like the hello your name endpoint
    /// </summary>
    /// <param name="app"></param>
    public void DefineEndpoints(WebApplication app)
    {
        app.MapPost("/Hello/{name}", (string name) => Results.Ok($"Hello {name}"));
        app.MapGet("/Hello", HelloWorld);
    }

    private static IResult HelloWorld()
    {
        return Results.Ok("Hello World");
    }
}