using Academy.TestWeek5.Core.BusinessLayer;
using Academy.TestWeek5.Core.Interfaces;
using Academy.TestWeek5.EF;
using Academy.TestWeek5.EF.Repositories;
using Academy.TestWeek5.MVC.Filters;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academy.TestWeek5
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
            services.AddScoped<IBusinessLayer, MainBusinessLayer>();
            services.AddScoped<IPiattoRepository, EFPiattoRepository>();
            services.AddScoped<IAccountRepository, EFAccountRepository>();
            

            services.AddDbContext<PiattoContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("Ristorante"))
                );

            services.AddAuthorization(options => {
                options.AddPolicy("AccountRistoratore", policy => policy.RequireRole("Ristoratore"));
                options.AddPolicy("AccountCliente", policy => policy.RequireRole("Cliente"));
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = new PathString("/Account/Login");
                    options.AccessDeniedPath = new PathString("/Account/Forbidden");
                });
            services.AddControllersWithViews(
            //options => options.Filters.Add(new PiattoCodeFilter("EMP-001"))
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            //app.UseExecutionTime();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
