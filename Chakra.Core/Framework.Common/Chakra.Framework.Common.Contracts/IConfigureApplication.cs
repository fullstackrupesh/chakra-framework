using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace Chakra.Framework.Common.Contracts
{
    public interface IConfigureApplication
    {
        void Configure(IApplicationBuilder app, IConfiguration configuration);
    }
}
