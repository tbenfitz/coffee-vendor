using System;
using CoffeeVendor.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendor.Classes
{
   public class VendingOrder : IVendingOrder
   {
      public List<ICoffee> CoffeeToVend { get; set; }
   }
}
