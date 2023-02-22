using Demo.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.Use(async (httpContext,next) =>
{
    await httpContext.Response.WriteAsync("I am from Middleware 1\n\n");
    await next();
});


app.Use(async (httpContext, next) =>
{
    await httpContext.Response.WriteAsync("I am from Middleware 2\n\n");
    await next();
});

app.Map("/Documents", builder =>
{

    builder.UseDemoMiddleware();

});

app.Run(async (httpContext) =>
{
    await httpContext.Response.WriteAsync("I am from Middleware 3");
});


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
