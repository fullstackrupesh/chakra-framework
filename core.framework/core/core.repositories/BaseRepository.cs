using core.common.enums;
using core.contracts;
using core.contracts.repositories;
using core.persistence;
using System;

namespace core.repositories
{
    public class BaseRepository<TDbModel> : IBaseRepository<TDbModel>
        where TDbModel : class, IDbModel, new()
    {
        private ApplicationDbContext context;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        public virtual bool CanPerform(ModuleAction action)
        {
            switch (action)
            {
                case ModuleAction.None:
                    return false;
                case ModuleAction.Get:
                    return false;
                case ModuleAction.Insert:
                    return false;
                case ModuleAction.Update:
                    return false;
                case ModuleAction.Delete:
                    return false;
                case ModuleAction.Purge:
                    return false;
                default:
                    return false;
            }
        }
        
        public bool CanGet()
        {            
            return true;
        }

        public bool CanInsert()
        {
            throw new NotImplementedException();
        }

        public bool CanUpdate()
        {
            throw new NotImplementedException();
        }

        public bool CanDelete()
        {
            throw new NotImplementedException();
        }

        public bool CanPurge()
        {
            throw new NotImplementedException();
        }
    }
}
