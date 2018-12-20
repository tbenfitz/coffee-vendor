using System;
using CoffeeVendor.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendor.Classes
{
   public class CoffeeCreamer : CoffeeDecorator
   {
      public CoffeeCreamer(ICoffee coffeeToVend) : base(coffeeToVend)
      {
         this._coffeeToVend = coffeeToVend;
      }

      public override decimal Price
      {
         get { return this._coffeeToVend.Price + kCostPerItem; }
      }

      private const decimal kCostPerItem = 0.50m;

      private ICoffee _coffeeToVend;
   }
}
