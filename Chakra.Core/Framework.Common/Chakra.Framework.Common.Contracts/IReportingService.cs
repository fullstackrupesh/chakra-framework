using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chakra.Framework.Common.Contracts
{
    public interface IReportingService<DbModel> : ICrudService<DbModel>
    {
        IQueryable<DbModel> RunQuery();
    }
}
