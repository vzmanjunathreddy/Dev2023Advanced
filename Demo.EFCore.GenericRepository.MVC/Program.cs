using Demo.EFCore.GenericRepository.MVC.Data;
using Demo.EFCore.GenericRepository.MVC.Interfaces;
using Demo.EFCore.GenericRepository.Service;
using Demo.EFCore.MVC.Data;
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

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
