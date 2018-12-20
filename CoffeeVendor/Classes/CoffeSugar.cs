using System;
using CoffeeVendor.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendor.Classes
{
   public class CoffeeSugar : CoffeeDecorator
   {
      public CoffeeSugar(ICoffee coffeeToVend) : base(coffeeToVend)
      {
         this._coffeeToVend = coffeeToVend;
      }

      public override decimal Price
      {
         get { return this._coffeeToVend.Price + kCostPerItem; }
      }

      private const decimal kCostPerItem = 0.25m;

      private ICoffee _coffeeToVend;
   }   
}
