using System.Reflection;
using Catalog;

var version = typeof(Items).Assembly
    .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/health", () => Results.Ok(new { status = "ok", version }));
app.MapGet("/items/{sku}", (string sku) =>
    Items.Find(sku) is { } item ? Results.Ok(item) : Results.NotFound());

app.Run();
