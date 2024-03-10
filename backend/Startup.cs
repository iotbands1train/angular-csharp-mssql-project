using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using backend.Services;

namespace backend
{
    public class Startup
    {
        // Constructor to inject IConfiguration
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // ConfigureServices method to add services to the container
        public void ConfigureServices(IServiceCollection services)
        {
            // Add MVC controllers and views
            services.AddControllersWithViews();
        }

        // Configure method to configure the HTTP request pipeline
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // If in development environment, use developer exception page; otherwise, use error handler and enable HSTS
            if (env.IsDevelopment())
            {
                // Enable developer exception page
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // Use error handler
                app.UseExceptionHandler("/Home/Error");
                // Enable HTTP Strict Transport Security (HSTS)
                app.UseHsts();
            }
            // Redirect HTTP requests to HTTPS
            app.UseHttpsRedirection();
            // Serve static files like CSS, JavaScript, and images
            app.UseStaticFiles();
            // Enable routing
            app.UseRouting();
            // Enable authorization
            app.UseAuthorization();
            // Configure endpoints for controllers
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}


// dotnet ef migrations add <MigrationName>
// dotnet ef migrations add InitialCreate
// dotnet ef migrations add AddNewColumnToUserTable
// dotnet ef database update
// dotnet run

