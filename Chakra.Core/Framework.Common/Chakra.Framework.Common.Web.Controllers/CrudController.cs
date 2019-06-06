using Chakra.Framework.Common.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Chakra.Framework.Common.Web.Controllers
{
    public class CrudController<WebModel, DbModel> : ControllerBase
    {
        protected readonly ICrudService<DbModel> Service;

        public CrudController(ICrudService<DbModel> service)
        {
            Service = service ?? throw new ArgumentNullException(nameof(service));
        }


    }
}
