using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace core.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<TModel> : Controller
      where TModel: class, new()
    {
      private readonly ApplicationDbContext dbContext;

      public BaseController(ApplicationDbContext context)
      {
         dbContext = context;
      }

      [HttpGet]
      public IEnumerable<TModel> GetAll()
      {
         return dbContext.Set<TModel>();
      }      
    }
}