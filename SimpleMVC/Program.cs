var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.Use(async (context, next) =>
{
    if ((!context.User.Identity.IsAuthenticated) && (!context.Request.Path.StartsWithSegments("/Account/Login")))
    {
        // Je¿eli u¿ytkownik nie jest zalogowany, przekieruj do strony logowania
        context.Response.Redirect("/Account/Login");
        return;
    }
    else if(context.User.Identity.IsAuthenticated)
    {
        // Je¿eli u¿ytkownik jest zalogowany i jest na stronie logowania, przekieruj go gdzieœ indziej (np. na stronê g³ówn¹)
        context.Response.Redirect("/");
        return;
    }

    await next();
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
