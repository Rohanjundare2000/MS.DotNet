namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

                  // Add services to the container.
                 // Services: MiddleWare
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error"); //Deployement Mode
            }
            //Configure: UseStaticFiles,UseAuthorization,MapControllerRoute
            app.UseStaticFiles();

            app.UseRouting();
            //uses Conventional routing Mechanism.
            app.UseAuthorization();
            // UseAuthorization,MapControllerRoute, Run one of three only one is used;
            app.MapControllerRoute(           // Valid Route Are Accepted;
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            // default Name: Home     
            // id ?= Optional = root data
            // http://localhost:1234/ControllerName/Action/id]
            // http://localhost:1234/ControllerName/x/5
            // http://localhost:1234/ControllerName/x/m1
            // http://localhost:1234/ControllerName/x
            // http://localhost:1234/ControllerName
            // While naming a controller must be suffix of Controller : cause your code is not run so plz give.

            
            app.Run();
        }
    }
}
