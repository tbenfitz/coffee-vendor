using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendor.Interfaces
{
   public interface IVendingOrder
   {
      List<ICoffee> CoffeeToVend { get; set; }
   }
}
