using Db_Frist.Models;
using Microsoft.EntityFrameworkCore;

namespace Db_Frist
{
    public class Program
    {
        public static void Main(string[] args)
        {
          
        

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<Jkjune2024Context>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("Jkjune2024Context.cs")));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
