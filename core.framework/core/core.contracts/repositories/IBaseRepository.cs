using core.common.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace core.contracts.repositories
{
    public interface IBaseRepository<TModel> where TModel: class,  IDbModel, new()
    {        
        bool CanGet();
        bool CanInsert();
        bool CanUpdate();
        bool CanDelete();
        bool CanPurge();
    }
}
