using SIGCora.Presentation.Filters;
using SIGCora.Presentation.Areas.Security.Services.CompanyService;
using SIGCora.Presentation.Areas.Security.Services.ConstantService;
using SIGCora.Presentation.Areas.Security.Services.PageCompanyService;
using SIGCora.Presentation.Areas.Security.Services.PageService;
using SIGCora.Presentation.Areas.Security.Services.RoleService;
using SIGCora.Presentation.Areas.Security.Services.UbigeoService;
using SIGCora.Presentation.Helpers;
using SIGCora.Presentation.Services;
using SIGCora.Presentation.Services.AuthService;
using SIGCora.Presentation.Services.RolePermissionService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(option =>
{
    option.Filters.Add<AuthorizationController>();
});
builder.Services.AddResponseCaching();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
});

builder.Services.Configure<ApiEndpoints>(builder.Configuration.GetSection("ApiEndpoints"));
var endpoints = builder.Configuration.GetSection("ApiEndpoints").Get<ApiEndpoints>();


builder.Services.AddHttpContextAccessor();
builder.Services.AddHttpClient(ConstantsHelper.HttpClientNames.ApiCommerce360, client => client.BaseAddress = new Uri(endpoints!.Commerce360))
                .AddHttpMessageHandler<AccessTokenHandler>();

builder.Services.AddHttpClient(ConstantsHelper.HttpClientNames.ApiAuth360, client => client.BaseAddress = new Uri(endpoints!.Commerce360));
builder.Services.AddScoped<AccessTokenHandler>();
builder.Services.AddScoped<IApiService, ApiService>();
builder.Services.AddScoped<IApiServiceFactory, ApiServiceFactory>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IRolePermissionService, RolePermissionService>();

builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IPageService, PageService>();
builder.Services.AddScoped<IPageCompanyService, PageCompanyService>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IUbigeoService, UbigeoService>();
builder.Services.AddScoped<IConstantService, ConstantService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
