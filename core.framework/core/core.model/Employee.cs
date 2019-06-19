using core.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace core.model
{
   [Model("Employee")]
   public class Employee: DbModel
   {
      public string FullName { get; set; }
      public string Designation { get; set; }
   }
}
