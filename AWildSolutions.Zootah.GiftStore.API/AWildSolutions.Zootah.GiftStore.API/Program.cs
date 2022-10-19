using AWildSolutions.Zootah.GiftStore.API.Extensions;
using AWildSolutions.Zootah.GiftStore.API.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointDefinitions(typeof(IEndpoint));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

app.UseEndpoint();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();