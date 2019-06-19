using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace core.contracts
{
   public interface IConfigureApplication
   {
      void Configure(IApplicationBuilder builder, IConfiguration configuration);
   }
}
