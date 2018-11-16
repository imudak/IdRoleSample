using System;
using IdRoleSample.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(IdRoleSample.Areas.Identity.IdentityHostingStartup))]
namespace IdRoleSample.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<IdRoleSampleContext>(options =>
                    options.UseInMemoryDatabase("IdRoleSampleContext"));
                //options.UseSqlServer(
                //    context.Configuration.GetConnectionString("IdRoleSampleContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<IdRoleSampleContext>();
            });
        }
    }
}