var builder = WebApplication.CreateBuilder(args);
const string MiCors = "TPI2021Cors";

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<TPIContext>(
    options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
    );
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

app.Run();
