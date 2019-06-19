using core.model;
using System.Collections.Generic;

namespace core.masters.model
{
   public class Category : DbModel
   { 
      public string Name { get; set; }
      public List<Product> Products { get; set; }
   }
}
