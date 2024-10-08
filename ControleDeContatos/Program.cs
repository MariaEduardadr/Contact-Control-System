using System.Security.Cryptography.X509Certificates;
using ControleDeContatos.Data;
using Microsoft.EntityFrameworkCore;

namespace ControleDeContatos
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

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

        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = "SuaConnectionStringDoSQLServer";

            services.AddDbContext<BancoContex>(options =>
                options.UseSqlServer(connectionString));
        }
    }
}