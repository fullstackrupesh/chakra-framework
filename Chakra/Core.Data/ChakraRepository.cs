using Chakra.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chakra.Core.Data
{
    public class ChakraRepository<T, TId> : IChakraRepository<T, TId>
        where T : class, new()
        where TId : struct
    {
        public void Delete(TId id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get()
        {
            throw new NotImplementedException();
        }

        public TId Insert(T record)
        {
            throw new NotImplementedException();
        }

        public void Update(T record)
        {
            throw new NotImplementedException();
        }
    }
}