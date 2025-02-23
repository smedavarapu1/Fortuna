using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Fortuna.Web.Blazor.Data;
using MudBlazor.Services;
using MudBlazor;
using Fortuna.Web.Blazor.Services;
using Fortuna.Web.Blazor.Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddMudServices();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7063/") });
builder.Services.AddScoped<IFortunaAPIService, FortunaApiService>();

builder.Services.AddHttpClient("FortunaApi", client =>
{
    client.BaseAddress = new Uri("https://localhost:7063/");
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
