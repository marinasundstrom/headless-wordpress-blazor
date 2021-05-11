using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PeachPied.Demo
{
    class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddResponseCompression();
            services.AddWordPress(options =>
            {
                // options.SiteUrl =
                // options.HomeUrl = "http://localhost:5004";
                
                // options.PluginContainer.Add(new DashboardPlugin());
            });
        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env, IConfiguration configuration)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseWordPress();

            app.UseDefaultFiles();
        }
    }
}
