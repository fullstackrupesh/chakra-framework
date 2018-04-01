using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Chakra.Core.Repositories
{
    public interface IChakraRepository<T> : IDisposable
    {
        Task<IEnumerable<T>> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
        void Insert(T record);
        void Update(T record);
        void Delete(T id);
        Task<int> Save();
    }
}