using System.Data.Entity;

namespace Chakra.Core.Repositories
{
    public partial class ChakraRepositoryContext : DbContext
    {
        public ChakraRepositoryContext() : base("name=ChakraRepositoryContext")
        {

        }
    }
}