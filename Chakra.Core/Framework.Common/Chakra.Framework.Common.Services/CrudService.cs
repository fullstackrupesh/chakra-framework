using Chakra.Framework.Common.Contracts;
using Chakra.Framework.Common.Model;
using System;
using System.Linq;

namespace Chakra.Framework.Common.Services
{
    public class CrudService<DbModel> : ICrudService<DbModel>
        where DbModel : EntityModel
    {
        public IQueryable<DbModel> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public DbModel GetAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public void AddAsync(DbModel model)
        {
            throw new NotImplementedException();
        }

        public void DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }
        
        public void UpdateAsync(DbModel model)
        {
            throw new NotImplementedException();
        }
    }
}
