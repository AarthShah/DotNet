using Microsoft.Extensions.Caching.Memory;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMemoryCache();

var app = builder.Build();

app.MapGet("/", () => Results.Ok(new
{
    message = "Welcome to Experiment 10 - Logging + Caching Demo",
    endpoints = new { time = "/time" }
}));

app.MapGet("/time", (ILogger<Program> logger, IMemoryCache cache) =>
{
    const string key = "cached-time";

    if (!cache.TryGetValue(key, out string? value))
    {
        value = DateTime.Now.ToString("HH:mm:ss");
        cache.Set(key, value, TimeSpan.FromSeconds(20));
        logger.LogInformation("Cache created at {Time}", value);
    }
    else
    {
        logger.LogInformation("Cache reused: {Time}", value);
    }

    return Results.Ok(new { message = "Logging + caching demo", serverTime = value });
});

app.Run();
