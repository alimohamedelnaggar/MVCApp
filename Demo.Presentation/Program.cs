using Demo.BLL.Interfaces;
using Demo.BLL.Repositories;
using Demo.BLL;
using Demo.DAL.Data.Contexts;
using Demo.DAL.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Demo.Presentation.Helper;

namespace Demo.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var Builder = WebApplication.CreateBuilder(args);
            Builder. Services.AddControllersWithViews();
            Builder.Services.AddDbContext<AppDbContext>(options => {
                options.UseSqlServer(Builder.Configuration.GetConnectionString("DefaultConnection"));
            }); // allow DI

            Builder.Services.AddAutoMapper(M => M.AddProfile(new MappingProfiles()));
            Builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            Builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            Builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            Builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            Builder.Services.ConfigureApplicationCookie(config => config.LoginPath = "/Account/SignIn");

            var app= Builder.Build();

            if (app.Environment.IsDevelopment())
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
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            app.Run();
        }
        
       
    }
}
