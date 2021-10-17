using System;
using Elebris.Tooling.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Elebris.Tooling.Areas.Identity.IdentityHostingStartup))]
namespace Elebris.Tooling.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ElebrisToolingContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ElebrisToolingContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>() //added
                    .AddEntityFrameworkStores<ElebrisToolingContext>();
            });
        }
    }
}