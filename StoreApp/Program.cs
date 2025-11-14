using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<RepositoryContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:sqlConnection"]);
});

var app = builder.Build();

app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();

app.MapControllerRoute(name:"default",pattern:"{controller=Home}/{action=Index}/{id?}");


app.Run();
