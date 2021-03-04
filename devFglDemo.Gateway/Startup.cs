using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using devDemo.Infra.DataContext;
using devDemo.Infra.Repositories;
using devFglDemo.Application.Contracts;
using devFglDemo.Application.Requests.MarcaRequests;
using devFglDemo.Application.Requests.UserRequests;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

namespace devDemo.Gateway
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson(o => { o.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore; });

            services.AddResponseCompression();
            services.AddMvc();

            services.AddDbContext<DemoContext>(opt => opt.UseInMemoryDatabase("Database"));
            //services.AddDbContext<DemoContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("connectionString")));

            services.AddScoped<DemoContext, DemoContext>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserV2Repository, UserV2Repository>();
            services.AddTransient<ActiveUserByIdRequestHandler, ActiveUserByIdRequestHandler>();
            services.AddTransient<CreateUserRequestHandler, CreateUserRequestHandler>();
            services.AddTransient<GetUserByIdRequestHandler, GetUserByIdRequestHandler>();
            services.AddTransient<InactiveUserByIdRequestHandler, InactiveUserByIdRequestHandler>();
            services.AddTransient<UpdateUserRequestHandler, UpdateUserRequestHandler>();
            services.AddTransient<DeleteUserRequestHandler, DeleteUserRequestHandler>();
            services.AddTransient<IMarcaRepository, MarcaRepository>();
            services.AddTransient<CreateMarcaRequestHandler, CreateMarcaRequestHandler>();

            services.AddSwaggerGen(c =>
           {
               c.SwaggerDoc("v1", new OpenApiInfo { Title = "API Demonstração Cartão Ponto", Version = "v1" });
           });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Demonstração Cartão Ponto");
            });

            app.UseRouting();
            app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

            app.UseAuthentication();
            app.UseAuthorization();



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
