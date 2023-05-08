using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace webapi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<DAL.IProductRepository, DAL.ProductRepository>();

            // Add the OpenAPI/Swagger configuration here
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Add the OpenAPI/Swagger configuration here

            app.UseRouting();
            app.UseEndpoints(e => e.MapControllers());
        }
    }
}
