using Microsoft.EntityFrameworkCore;
using PokedexWeb.Data;
using PokedexWeb.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowedFrontend", policy =>
    {
        policy.WithOrigins("http://localhost:3000", "https://truongvo31.github.io")
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();
    });
});

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
if (string.IsNullOrEmpty(connectionString)) 
    throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(connectionString).EnableSensitiveDataLogging());

builder.Services.AddScoped<PokemonService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors("AllowedFrontend");


app.Use(async (context, next) =>
{
    var config = context.RequestServices.GetRequiredService<IConfiguration>();
    var env = context.RequestServices.GetRequiredService<IWebHostEnvironment>();

    var allowLocalFrontend =
        config.GetValue<bool>("AllowLocalFrontendInRelease");

    if (!env.IsDevelopment() && allowLocalFrontend)
    {
        var origin = context.Request.Headers.Origin.ToString();

        if (origin == "http://localhost:3000")
        {
            var expectedKey = config["DevFrontendAccessKey"];
            var actualKey = context.Request.Headers["X-Dev-Access-Key"].ToString();

            if (string.IsNullOrWhiteSpace(expectedKey) ||
                actualKey != expectedKey)
            {
                context.Response.StatusCode = StatusCodes.Status403Forbidden;
                await context.Response.WriteAsync("Forbidden.");
                return;
            }
        }
    }

    await next();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseStaticFiles();

app.MapFallback(context =>
{
    if (context.Request.Path.StartsWithSegments("/api"))
    {
        // Let API return proper 404
        context.Response.StatusCode = StatusCodes.Status404NotFound;
        return Task.CompletedTask;
    }

    // Otherwise return SPA index.html
    context.Response.ContentType = "text/html";
    return context.Response.SendFileAsync("wwwroot/index.html");
});

app.MapControllers();

app.MapGet("/health", () => "OK");

app.Run();
