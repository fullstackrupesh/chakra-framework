using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.web.masters.Data;
using core.web.Controllers;
using core.web.masters.Models;
using core.web.masters.ViewModels;
using Microsoft.AspNetCore.Mvc;
using core.contracts.repositories;

namespace core.web.masters.Controllers
{
    public class CurrencyController : MasterController<Currency, CurrencyViewModel>
    {
        public CurrencyController(IMasterRepository<Currency> repository) : base(repository) 
        {

        }
    }
}