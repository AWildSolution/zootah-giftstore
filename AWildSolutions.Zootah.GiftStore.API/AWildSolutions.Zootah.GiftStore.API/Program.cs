using AWildSolutions.Zootah.GiftStore.API.Context;
using AWildSolutions.Zootah.GiftStore.API.Extensions;
using AWildSolutions.Zootah.GiftStore.API.Interfaces;
using AWildSolutions.Zootah.GiftStore.API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ProductContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDbContext<WebCartContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddEndpointDefinitions(typeof(IEndpoint));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var db = app.Services.GetRequiredService<ProductContext>();
db.Database.EnsureCreated();

app.UseEndpoint();

app.UseHttpsRedirection();

app.Run();