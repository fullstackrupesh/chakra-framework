using Chakra.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Chakra.Core
{
    public class ChakraController<BusinessObject, DataObject, Repository> : Controller
        where BusinessObject : class, IBusinessObject
        where DataObject : class, IDataObject
        where Repository : class, IRepository

    {

        public ChakraController()
        {

        }

        public virtual ActionResult Index()
        {
            return View();
        }

    }
}
