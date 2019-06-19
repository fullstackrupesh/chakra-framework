using core.contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace core.persistence
{
   public class ConfigureServices : IConfigureService
   {
      public void Configure(IServiceCollection services, IConfiguration configuration)
      {
         services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("core.web")));
      }
   }
}
