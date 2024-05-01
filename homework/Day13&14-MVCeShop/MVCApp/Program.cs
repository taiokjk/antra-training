using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Infrastructure.Data;
using Infrastructure.Repository;
using Infrastructure.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add db context
builder.Services.AddDbContext<EShopDbContext>(context =>
{
    context.UseSqlServer(builder.Configuration.GetConnectionString("MVCEshopDb"));
});

#region Repository Injection
builder.Services.AddScoped<IRegionRepository, RegionRepository>();
builder.Services.AddScoped<IShipperRepository, ShipperRepository>();
#endregion

#region Service Injection
builder.Services.AddScoped<IRegionService, RegionService>();
builder.Services.AddScoped<IShipperService, ShipperService>();
#endregion



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
