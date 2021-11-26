using System;
using CustomizeAuthentication.Areas.Identity.Data;
using CustomizeAuthentication.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(CustomizeAuthentication.Areas.Identity.IdentityHostingStartup))]
namespace CustomizeAuthentication.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<CAContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("CAContextConnection")));
                // Change RequireConfirmedAccount to false, this demo will not required user confirm by Email and modified some options for testing convenience
                services.AddDefaultIdentity<CAUser>(options => {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequiredLength = 3;
                    })
                    .AddEntityFrameworkStores<CAContext>();
            });
        }
    }
}