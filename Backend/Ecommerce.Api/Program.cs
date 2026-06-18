using Ecommerce.Api.Domain.Interfaces;
using Ecommerce.Api.Infrastructure.Data;
using Ecommerce.Api.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Api.Services;
using Ecommerce.Api.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

var connectionSting = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options => 
   options.UseSqlServer(connectionSting));

// Injeção de dependencia para repositorios
builder.Services.AddScoped<IProductRepository, ProductRepository>();
// Injeção de dependencia para serviços
builder.Services.AddScoped<IProductService, ProductService>();

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
