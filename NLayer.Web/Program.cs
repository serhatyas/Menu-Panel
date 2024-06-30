using Autofac.Extensions.DependencyInjection;
using Autofac;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Repository;
using NLayer.Repository.Repositories;
using NLayer.Repository.UnitOfWork;
using NLayer.Service.Mapping;
using NLayer.Service.Services;
using NLayer.Service.Validations;
using System.Reflection;
using NLayer.Web.Modules;
using FluentValidation;
using NLayer.Web;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddControllers(option => { option.Filters.Add(new ValidateFilterAttribute()); }).AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<ProductDtoValidator>());

builder.Services.AddControllersWithViews().AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<ProductDtoValidator>()); ;


builder.Services.AddAutoMapper(typeof(MapProfile));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(option =>
{
    option.Cookie.Name = "NetCoreMvc.Auth";
    option.LoginPath = "/Admin/Login";
    option.AccessDeniedPath = "/Admin/Login";
});

builder.Services.AddDbContext<AppDbContext>(x =>
{

    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    {
        //ToDo dinamik assembly adýný aldýk.
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);

    });

});


builder.Services.AddScoped(typeof(NotFoundFilter<>));


builder.Host.UseServiceProviderFactory
    (new AutofacServiceProviderFactory());

builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterModule(new RepoServiceModule()));

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler("/Home/Error");
if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name: "admin",
        areaName: "Admin",
        pattern: "admin/{controller=Home}/{action=Index}/{id?}"
    );
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
    );
});


//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapAreaControllerRoute(
//        name:"Admin",
//        areaName:"Admin",
//        pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
//        );
//        endpoints.MapDefaultControllerRoute();
//});

app.Run();
