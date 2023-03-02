using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MySql.EntityFrameworkCore.Extensions;
using ASP_example.data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PostData>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("PostData") ?? throw new InvalidOperationException("Connection string 'PostData' not found.")));

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

// enter page setting
app.MapControllerRoute(
    name: "main",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
