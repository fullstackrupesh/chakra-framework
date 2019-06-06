using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chakra.Framework.Common.Contracts
{
    public interface ICrudService<DbModel>
    {
        void AddAsync(DbModel model);

        IQueryable<DbModel> GetAllAsync();

        DbModel GetAsync(int Id);

        void UpdateAsync(DbModel model);

        void DeleteAsync(int Id);            
    }
}
