using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using DotNetTagHelpers.Models;

namespace DotNetTagHelpers
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IRepository, MemoryRepository>();
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app)
        {
            app.Map("/mvcapp", appBuilder => {
                appBuilder.UseStatusCodePages();
                appBuilder.UseDeveloperExceptionPage();
                appBuilder.UseStaticFiles();
                appBuilder.UseMvcWithDefaultRoute();
            });
        }
    }
}