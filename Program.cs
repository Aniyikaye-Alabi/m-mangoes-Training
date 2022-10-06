using GenerateReceipt.Data;
using GenerateReceipt.ImplClasses;
using GenerateReceipt.Interfaces;
using GenerateReceipt.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//My Servies
builder.Services.AddTransient<IDate, ShortDate>();
builder.Services.AddTransient<ICrudRepository, CrudRepository>();

builder.Services.AddDbContext<GenerateDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GenerateDbContext")));

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
