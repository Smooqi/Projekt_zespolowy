using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using SimpleMVC.Data;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("Default")
        );
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Account/LoginErr");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseDefaultFiles();

app.UseRouting();

app.UseAuthorization();

/*

app.Use(async (context, next) =>
{
    if (!context.User.Identity.IsAuthenticated)
    {
        if (!context.Request.Path.StartsWithSegments("/Account/Login"))
        {
            // Je¿eli u¿ytkownik nie jest zalogowany i nie próbuje uzyskaæ dostêpu do strony logowania,
            // przekieruj go do strony logowania
            context.Response.Redirect("/Account/Login");
return;
        }
    }
    else // U¿ytkownik jest zalogowany
{
    if (context.Request.Path.StartsWithSegments("/Account/Login"))
    {
        // Je¿eli u¿ytkownik jest zalogowany i jest na stronie logowania,
        // przekieruj go gdzieœ indziej (np. na stronê g³ówn¹)
        context.Response.Redirect("/");
        return;
    }
}

// Kontynuuj przetwarzanie ¿¹dania przez kolejne middleware
await next();
});*/


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=StronaLogowania}/{id?}");

app.MapControllerRoute(
    name: "other",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
