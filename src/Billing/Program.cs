using System.Reflection;
using Billing;

var version = typeof(Invoice).Assembly
    .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/healthz", () => Results.Ok(new { status = "ok", version }));
app.MapPost("/invoices/total", (Line[] lines) => Results.Ok(new { total = Invoice.Total(lines) }));

app.Run();
