using AspMvcAssignment.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddDistributedMemoryCache();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

//app.MapControllerRoute(
//    name: "Index",
//    pattern: "Ajax",
//    defaults: new { controller = "Ajax", action = "Index" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=PeopleDb}/{action=Index}/{id?}");
app.Run();
