using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AFS_Visa_Processing_System.Data;
namespace AFS_Visa_Processing_System
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<AFS_Visa_Processing_SystemContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("AFS_Visa_Processing_SystemContext") ?? throw new InvalidOperationException("Connection string 'AFS_Visa_Processing_SystemContext' not found.")));

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}