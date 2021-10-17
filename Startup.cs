using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Elebris.Database.Manager;
using Elebris.Database.Manager.Data;
using Elebris.Database.Manager.DataAccess;
using Elebris.Tooling.Areas.Identity;
using Microsoft.AspNetCore.Identity;
using Elebris.Tooling.Data;

namespace Elebris.Tooling
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<TokenProvider>();
            //https://stackoverflow.com/questions/51161729/addidentity-fails-invalidoperationexception-scheme-already-exists-identity
            services.AddSingleton(new ConnectionStringData
            {
                ConnectionString = "ElebrisData"
            });
            services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
            services.AddSingleton<ICharacterData, CharacterData>();
            services.AddSingleton<IStatData, StatData>();
            services.AddSingleton<IUserData, UserData>();
            services.AddSingleton<IEquipmentData, EquipmentData>();
            services.AddSingleton<IElebrisClassData, ElebrisClassData>();
            services.AddSingleton<ICharacterRaceData, CharacterRaceData>();

            //Singleton: Per Application
            //Scoped: Per User, can be used interchangeably in a WASM app.
            //Transient: Per Page
            services.AddSingleton<ICachedLists, CachedLists>();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            //Added for auth https://www.youtube.com/watch?v=Lp-0JtQbj84
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages(); //Added for auth
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
