using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Carpool.Model.Requests;
using Carpool.WebAPI.Database;
using Carpool.WebAPI.Filters;
using Carpool.WebAPI.Security;
using Carpool.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Carpool.WebAPI
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
            services.AddControllers();

            services.AddMvc(x => x.Filters.Add<ErrorFilter>());

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });

                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "basic"
                                }
                            },
                            new string[] {}
                    }
                });

                c.CustomSchemaIds(x => x.FullName);
            });

            services.AddAuthentication("BasicAuthentication")
            .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
            services.AddScoped<IKorisnikService, KorisnikService>();

            services.AddScoped<ICRUDService<Model.Automobil, AutomobilSearchRequest, AutomobilInsertRequest, AutomobilInsertRequest>, AutomobilService>();
            services.AddScoped<ICRUDService<Model.Vozac, VozacSearchRequest, VozacUpsertRequest, VozacUpsertRequest>, VozacService>();

            services.AddScoped<ICRUDService<Model.Obavijesti, ObavijestiSearchRequest, ObavijestiUpsertRequest, ObavijestiUpsertRequest>, ObavijestService>();
            services.AddScoped<ICRUDService<Model.Grad, object, Model.Grad, Model.Grad>, GradService>();

            services.AddScoped<IService<Model.KorisniciUloge, object>, BaseService<Model.KorisniciUloge, object, KorisniciUloge>>();
            services.AddScoped<IService<Model.Uloge, object>, BaseService<Model.Uloge, object, Uloge>>();

            services.AddScoped<IService<Model.TipObavijesti, object>, BaseService<Model.TipObavijesti, object, TipObavijesti>>();
            services.AddHttpContextAccessor();
            services.AddScoped<ICRUDService<Model.Voznja, VoznjaSearchRequest, VoznjaUpsertRequest, VoznjaUpsertRequest>, VoznjaService>();
            services.AddScoped<ICRUDService<Model.UsputniGradovi, UsputniGradoviSearchRequest, UsputniGradoviUpsertRequest, UsputniGradoviUpsertRequest>, UsputniGradoviService>();

            services.AddAutoMapper(typeof(Startup));


            services.AddDbContext<CarpoolContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}
