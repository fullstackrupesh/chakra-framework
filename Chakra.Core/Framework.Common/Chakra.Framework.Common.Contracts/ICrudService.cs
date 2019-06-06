using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chakra.Framework.Common.Contracts
{
    public interface ICrudService<DbModel>
    {
        void Add(DbModel model);

        IQueryable<DbModel> GetAll();

        DbModel Get(int Id);

        void Update(DbModel model);

        void Delete(int Id);        
    }
}
