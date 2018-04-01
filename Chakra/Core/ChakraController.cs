using Chakra.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Chakra.Core
{
    public class ChakraController<T, TId> : Controller
        where T : class, new()
        where TId : struct
    {
        protected IChakraRepository<T, TId> Repository { get; set; }

        public ChakraController()
        {

        }

        public virtual ActionResult Index()
        {
            return View();
        }

    }
}
