using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Lessons.LessonOne.Api.Models;
using Lessons.LessonOne.Api.Services;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Lessons.LessonOne.Api
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddScoped<CustomersService>()
                .AddScoped<IGetable<Customer>>((provider) => provider.GetRequiredService<CustomersService>())
                .AddScoped<ISetable<Customer>>((provider) => provider.GetRequiredService<CustomersService>())
                .AddScoped<ICustomersService>((provider) => provider.GetRequiredService<CustomersService>())
                .AddScoped<ICustomersProfileService, CustomersProfileService>();
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints((endpoints) =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
