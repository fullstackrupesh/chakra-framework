using core.model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace core.masters.model
{
    public class Currency : DbModel
    {
        [Required]
        [StringLength(3)]
        public string Ccy { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(3)]
        public string Symbol { get; set; }
    }
}
