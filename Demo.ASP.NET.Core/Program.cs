using Demo.ASP.NET.Core.Data;
using Demo.ASP.NET.Core.Interfaces;
using Demo.ASP.NET.Core.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddRazorPages(options =>
{
    options.Conventions.AddPageRoute("/Students/StudentsIndex", "");
});

builder.Services.AddSession();

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
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
