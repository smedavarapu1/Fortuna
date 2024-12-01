using Fortuna.Data.Contracts.Expense;
using Fortuna.Data.DbContenxt;
using Fortuna.Services.Contracts.Expense;
using Fortuna.Services.Profiles;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<FortunaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add AutoMapper with the single MappingProfile
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Automatically register services and repositories
var assembliesToScan = new[]
{
    Assembly.GetAssembly(typeof(IExpenseService)),  // Fortuna.Services
    Assembly.GetAssembly(typeof(IExpenseRepository)) // Fortuna.Data
};

// Loops through all the services and repositories and registers them.
RegisterDI(builder, assembliesToScan);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapControllers();
}

app.UseHttpsRedirection();


app.Run();

static void RegisterDI(WebApplicationBuilder builder, Assembly?[] assembliesToScan)
{
    foreach (var assembly in assembliesToScan)
    {
        foreach (var type in assembly.GetTypes())
        {
            if (type.IsClass && !type.IsAbstract)
            {
                // Register Services
                if (type.Name.EndsWith("Service"))
                {
                    var interfaceType = type.GetInterface($"I{type.Name}");
                    if (interfaceType != null)
                    {
                        builder.Services.AddScoped(interfaceType, type);
                    }
                }

                // Register Repositories
                if (type.Name.EndsWith("Repository"))
                {
                    var interfaceType = type.GetInterface($"I{type.Name}");
                    if (interfaceType != null)
                    {
                        builder.Services.AddScoped(interfaceType, type);
                    }
                }
            }
        }
    }
}