using QuishpeS_LigaPro_Clase03.Interface;
using QuishpeS_LigaPro_Clase03.Repositorios;

var builder = WebApplication.CreateBuilder(args);


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
