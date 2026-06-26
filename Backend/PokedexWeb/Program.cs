using Microsoft.EntityFrameworkCore;
using PokedexWeb.Data;
using PokedexWeb.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowedDev", policy =>
    {
        policy.WithOrigins("http://localhost:3000")
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();
    });

    options.AddPolicy("AllowedProd", policy =>
    {
        policy.WithOrigins("https://truongvo31.github.io")
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

app.UseCors("AllowedProd");

#if DEBUG
app.UseCors("AllowedDev");
#endif

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
