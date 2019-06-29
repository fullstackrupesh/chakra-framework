using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.contracts;
using core.contracts.repositories;
using core.repositories;
using Microsoft.AspNetCore.Mvc;

namespace core.web.Controllers
{
    public class MasterController<TDbModel, TViewModel> : Controller
        where TDbModel: class, IDbModel, new()
    {
        protected readonly IMasterRepository<TDbModel> Repository;

        public MasterController(IMasterRepository<TDbModel> repository)
        {            
            Repository = repository;
        }

        public virtual ActionResult Index()
        {
            IEnumerable<TDbModel> result = null;

            if(Repository.CanGet())
                result = Repository.GetAll();

            return View(result);
        }
    }
}