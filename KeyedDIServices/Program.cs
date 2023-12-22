using KeyedDIServices.Enums;
using KeyedDIServices.Interfaces;
using KeyedDIServices.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Keyed Dependency Injection Services:
builder.Services.AddKeyedScoped<IService, ServiceA>(DIKey.ServiceA);
builder.Services.AddKeyedScoped<IService, ServiceB>(DIKey.ServiceB);
builder.Services.AddKeyedScoped<IService, ServiceC>(DIKey.ServiceC);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
