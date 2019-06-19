using core.model;

namespace core.masters.model
{
   public class Product : DbModel
   {
      public string Name { get; set; }
      public decimal Price { get; set; }
      public Category Category { get; set; }
      public int CategoryId { get; set; }
   }
}
