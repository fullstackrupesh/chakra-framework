using core.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.web.Areas.masters.Models
{
    public class Currency : DbModel
    {
        public string Ccy { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
    }
}
