using System;
using System.Collections.Generic;
using System.Text;

namespace core.contracts.repositories
{
    public interface IMasterRepository<TDbModel> : IBaseRepository<TDbModel>
        where TDbModel : class, IDbModel, new()
    {
        IEnumerable<TDbModel> GetAll();

        TDbModel Get(int Id);

        TDbModel Get(Func<TDbModel, bool> query);

        void Insert(TDbModel dbModel);

        void Update(TDbModel dbModel);

        void Delete(int id);

        void Purge(int id);

        bool IsValid();
    }
}
