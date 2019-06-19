using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.masters.model;
using core.persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace core.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController<Product>
    {
      public ProductController(ApplicationDbContext context) : base(context)
      {

      }
    }
}