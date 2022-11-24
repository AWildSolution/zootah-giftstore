namespace AWildSolutions.Zootah.GiftStore.API.Interfaces;

public interface IEndpoint
{
    void DefineServices(IServiceCollection services);
    void DefineEndpoints(WebApplication app);
}