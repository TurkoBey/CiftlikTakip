using CiftlikTakip.MvcUI.Areas.admin.HttpApiServices;
using System.Net.Sockets;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession(); // HttpContext.Session'� kullanabilmek i�in ilgili servisi container a register etmeliyiz
builder.Services.AddHttpContextAccessor(); // Uygulama IHttpContextAccessor tipindeki bir nesnenin, istenilen alana inject edilebilmesi i�incontainer a register etmemiz gerekiyor

builder.Services.AddHttpClient();
builder.Services.AddScoped<IHttpApiService, HttpApiService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.Use(async (context, next) =>
{
    try
    {
        await next();
    }
    catch (Exception ex) when (ex is SocketException || ex is HttpRequestException)
    {
        context.Response.Redirect("/Home/Error"); // 404 sayfas�n�n yolunu d�zenleyin
    }
});

app.UseStaticFiles();

app.UseSession();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapAreaControllerRoute(
    name: "adminAreaDefault",
    areaName: "admin",
    pattern: "{area}/{controller=Authentication}/{action=LogIn}/{id?}"
  );
app.Run();
