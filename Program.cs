using Microsoft.EntityFrameworkCore;
using OnlineFood.DataDB;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register the OnlineFoodContext with the DI container
builder.Services.AddDbContext<OnlineFoodContext>(options =>
    options.UseSqlServer("Data Source=localhost\\sqlexpress;Initial Catalog=OnlineFood;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;"));

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
