using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Chakra.Framework.Common.Contracts
{
    public interface IConfigureService
    {
        void Configure(IServiceCollection services, IConfiguration configuration);
    }
}
