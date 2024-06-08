using AutoMapper;
using Demo.PL.helpers;
using Microsoft.EntityFrameworkCore;
using StoreTask.Core.Repositories.Contract;
using StoreTask.Repository.Contexts;
using StoreTask.Repository.Repository.Implementation;

namespace StoreTask.Razor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            #region Add services to the DI Container.

            builder.Services.AddRazorPages();

            builder.Services.AddScoped<IClientRepository, ClientRepository>();

            builder.Services.AddAutoMapper(M => M.AddProfile(new MappingProfiles()));


            builder.Services.AddDbContextPool<StoreTaskDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            #endregion


            var app = builder.Build();


            #region (Middlewares) Configure the HTTP request pipeline.

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            #endregion


            app.Run();
        }
    }
}
