using KnockKnockCodeChallenge.WebService.API.Service.Interfaces;
using KnockKnockCodeChallenge.WebService.API.Service.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace KnockKnockCodeChallenge.WebService.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the containers.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            //Initiate Setting File
            services.AddSingleton<IConfiguration>(Configuration);
         
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Knock Knock API", Version = "v1" });
            });

            services.AddTransient<IFibonacciNumberService, FibonacciNumberService>();
            services.AddTransient<IReverseWordsService, ReverseWordsService>();
            services.AddTransient<ITriangleTypeService, TriangleTypeService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Knock Knock API V1");
            });

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
