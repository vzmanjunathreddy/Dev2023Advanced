using Demo.Dependency.Injection.Service.LifeTimes.Data;
using Demo.Dependency.Injection.Service.LifeTimes.Interfaces;
using Demo.Dependency.Injection.Service.LifeTimes.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IOrdersRepository,OrdersRepository>();
builder.Services.AddTransient<IOrderService,OrderService>();

builder.Services.AddTransient<ITransientService, TransientService>();
builder.Services.AddScoped<IScopedService, ScopedService>();
builder.Services.AddSingleton<ISignleTonService, SingletonService>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();