using System;
using System.Collections.Generic;
using core.contracts;
using core.contracts.repositories;
using core.persistence;

namespace core.repositories
{
    public abstract class MasterRepository<TDbModel> : BaseRepository<TDbModel>, IMasterRepository<TDbModel>
        where TDbModel : class, IDbModel, new()
    {
        private readonly ApplicationDbContext context;

        public MasterRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            context = dbContext;
        }

        public IEnumerable<TDbModel> GetAll()
        {
            return context.Set<TDbModel>();
        }

        public TDbModel Get(int Id)
        {
            throw new NotImplementedException();
        }

        public TDbModel Get(Func<TDbModel, bool> query)
        {
            throw new NotImplementedException();
        }

        public void Insert(TDbModel dbModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TDbModel dbModel)
        {
            throw new NotImplementedException();
        }
        
        public bool IsValid()
        {
            throw new NotImplementedException();
        }

        public void Purge(int id)
        {
            throw new NotImplementedException();
        }        
    }
}
