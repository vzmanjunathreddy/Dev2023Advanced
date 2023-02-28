using Demo.MVC.EF.Data;
using Demo.MVC.EF.Interfaces;
using Demo.MVC.EF.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetSection("ConnectionString:ADVFoodDbContext").Value;

builder.Services.AddDbContext<ADVFoodDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddScoped<ICustomersRepository, CustomersRepository>();
builder.Services.AddTransient<IFoodOrdersService, FoodOrdersService>();
builder.Services.AddScoped<IOrdersRepository, OrdersRepository>();
builder.Services.AddTransient<IUnitofWork, UnitofWork>();

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
    pattern: "{controller=Items}/{action=Index}/{id?}");

app.Run();
