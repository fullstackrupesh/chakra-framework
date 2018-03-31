using Chakra.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Chakra.Web.Areas.Static.Models
{
    [Serializable]
    public class Entity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string ShortCode { get; set; }

        [Required]
        [StringLength(30)]
        public string ClearingCode { get; set; }

        public Address EntityAddress { get; set; }
    }
}