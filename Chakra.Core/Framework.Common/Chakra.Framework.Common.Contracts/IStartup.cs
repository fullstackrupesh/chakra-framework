using Microsoft.Extensions.Configuration;
using System;

namespace Chakra.Framework.Common.Contracts
{
    public interface IStartup
    {
        void Initialize(IServiceProvider kernel, IConfiguration configuration);
    }
}
