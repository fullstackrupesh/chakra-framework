using System;

namespace core.common
{
   public class ModelAttribute : Attribute
   {
      public string Name { get; set; }

      public ModelAttribute(string name)
      {
         Name = name;
      }
   }
}
