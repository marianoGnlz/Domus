using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Domus.Data;
using Domus.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
const string MiCors = "TPI2021Cors";

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<TPIContext>(
    options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
    );
builder.Services.AddDefaultIdentity<DomusUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<DomusContext>();
builder.Services.AddDbContext<DomusContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddRazorPages();

builder.Services.Configure<IdentityOptions>(options =>
{
    // Password settings.
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 6;

});


builder.Services.AddCors(
    option => 
        option.AddPolicy(name: MiCors,
                builder =>
                {
                    builder.WithOrigins("*").WithMethods("GET", "POST", "DELETE");
                }
            )
    );


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseCors(options =>
                options.WithOrigins("*")
                    .WithMethods("GET", "POST", "DELETE")
                    .AllowAnyHeader()
                    );


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
