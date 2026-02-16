using Microsoft.EntityFrameworkCore;
using UserAPI.Data;
using UserAPI.Repository.Implementations;
using UserAPI.Repository.Interfaces;
using UserAPI.Services.Implamentations;
using UserAPI.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection"); 
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlServer(connectionString));

builder.Services.AddControllers();

builder.Services.AddScoped<IPersonRepository, PersonRepository>(); // quando alguém pedir IPersonService, entregue um PersonService(DI)
builder.Services.AddScoped<IPersonService, PersonService>();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();