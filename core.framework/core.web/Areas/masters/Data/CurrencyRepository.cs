using core.persistence;
using core.repositories;
using core.web.masters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.web.masters.Data
{
    public class CurrencyRepository : MasterRepository<Currency>
    {
        public CurrencyRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
