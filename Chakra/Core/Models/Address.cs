using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chakra.Core.Models
{
    [Serializable]
    public class Address
    {
        [StringLength(255)]
        public string Street { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(50)]
        public string State { get; set; }
        [StringLength(50)]
        public string Country { get; set; }
        [StringLength(10)]
        public string Zip { get; set; }
    }
}
