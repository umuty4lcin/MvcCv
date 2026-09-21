using Microsoft.EntityFrameworkCore;
using MvcCv.Models;
using MvcCv.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped(typeof(GenericRepository<>));

builder.Services.AddScoped<DeneyimRepository>();
builder.Services.AddScoped<EgitimRepository>();
builder.Services.AddScoped<HobiRepository>();
builder.Services.AddScoped<iletisimRepository>();
builder.Services.AddScoped<SertifikaRepository>();
builder.Services.AddScoped<YetenekRepository>();
builder.Services.AddScoped<HakkimdaRepository>();
builder.Services.AddScoped<SosyalMedyaRepository>();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Login/Index";

        options.ExpireTimeSpan = TimeSpan.FromHours(1);
    });

builder.Services.AddAuthorization(options =>
{
    options.FallbackPolicy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets().AllowAnonymous();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
