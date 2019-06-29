using core.contracts;
using core.contracts.repositories;
using core.web.masters.Data;
using core.web.masters.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.web.Areas.masters.Startup
{
    public class ConfigureService : IConfigureService
    {
        public void Configure(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IMasterRepository<Currency>, CurrencyRepository>();
        }
    }
}
