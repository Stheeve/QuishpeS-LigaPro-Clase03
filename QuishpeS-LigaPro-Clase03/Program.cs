using QuishpeS_LigaPro_Clase03.Interface;
using QuishpeS_LigaPro_Clase03.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QuishpeS_LigaPro_Clase03.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<QuishpeS_LigaPro_Clase03Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("QuishpeS_LigaPro_Clase03Context") ?? throw new InvalidOperationException("Connection string 'QuishpeS_LigaPro_Clase03Context' not found.")));


builder.Services.AddScoped<IEquipoRepository, EquipoRepository>();


builder.Services.AddControllersWithViews();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
   
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
