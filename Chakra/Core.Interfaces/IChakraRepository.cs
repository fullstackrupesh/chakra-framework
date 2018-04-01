using System.Collections.Generic;

namespace Chakra.Core.Interfaces
{
    public interface IChakraRepository<T, TId>
        where T : class, new()
        where TId : struct
    {
        TId Insert(T record);
        IEnumerable<T> Get();
        void Update(T record);
        void Delete(TId id);
    }
}