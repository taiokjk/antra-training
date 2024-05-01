using AutoMapper;
using Core.RepositoryContracts;
using Infrastructure.Data;
using Infrastructure.Helpers;
using Infrastructure.Repository;
using Infrastructure.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Depencency Injections
#region repository_injection
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
#endregion

#region service_injection
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();
#endregion

builder.Services.AddDbContext<EcommerceDbContext>(context =>
{
    context.UseSqlServer(builder.Configuration.GetConnectionString("EcomerceDb"));
});

// Add auto mapper
builder.Services.AddAutoMapper(typeof(Program), typeof(ApplicationMapper));

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
