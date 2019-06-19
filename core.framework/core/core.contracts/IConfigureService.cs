using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace core.contracts
{
   public interface IConfigureService
   {
      void Configure(IServiceCollection services, IConfiguration configuration);
   }
}
