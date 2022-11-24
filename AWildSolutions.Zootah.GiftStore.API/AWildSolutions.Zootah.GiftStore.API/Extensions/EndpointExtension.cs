using AWildSolutions.Zootah.GiftStore.API.Interfaces;

namespace AWildSolutions.Zootah.GiftStore.API.Extensions;

public static class EndpointExtension
{
    public static void AddEndpointDefinitions(this IServiceCollection services, params Type[] scanMarkers)
    {
        List<IEndpoint> endpointDefinitions = new List<IEndpoint>();

        foreach (Type marker in scanMarkers)
        {
            endpointDefinitions.AddRange(
                marker.Assembly.ExportedTypes
                    .Where(c => typeof(IEndpoint).IsAssignableFrom(c) && !c.IsInterface && !c.IsAbstract)
                    .Select(Activator.CreateInstance).Cast<IEndpoint>());
        }

        foreach (IEndpoint endpoint in endpointDefinitions)
        {
            endpoint.DefineServices(services);
        }

        services.AddSingleton(endpointDefinitions as IReadOnlyCollection<IEndpoint>);
    }

    public static void UseEndpoint(this WebApplication app)
    {
        IReadOnlyCollection<IEndpoint> endpoints = app.Services.GetRequiredService<IReadOnlyCollection<IEndpoint>>();

        foreach (IEndpoint endpoint in endpoints)
        {
            endpoint.DefineEndpoints(app);
        }
    }
}