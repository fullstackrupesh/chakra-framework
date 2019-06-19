using Microsoft.Extensions.Configuration;
using System;

namespace core.contracts
{
   public interface IStartup
   {
      void Initialize(IServiceProvider kernel, IConfiguration configuration);
   }
}
