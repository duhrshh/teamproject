using Microsoft.EntityFrameworkCore;
using TheClassics.Data;
using TheClassics.Services;

var builder = WebApplication.CreateBuilder(args);

//  EF Core + SQLite
builder.Services.AddDbContext<ApplicationDbContext>(opts =>
    opts.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<DbInitializer>();

//  Application services
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<CartService>();

//  Blazor Server + Razor Pages
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var app = builder.Build();

//  Seed database on startup
using (var scope = app.Services.CreateScope())
{
    var initializer = scope.ServiceProvider.GetRequiredService<DbInitializer>();
    await initializer.SeedAsync();
}

//  Standard middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

//  Endpoint mapping
app.MapRazorPages();               // for _Host.cshtml and any other Razor Pages
app.MapBlazorHub();                // for the SignalR endpoint
app.MapFallbackToPage("/_Host");   // fall back to _Host for client routing

app.Run();