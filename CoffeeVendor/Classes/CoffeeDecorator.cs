using System;
using CoffeeVendor.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendor.Classes
{
   public abstract class CoffeeDecorator : ICoffee
   {            
      public CoffeeDecorator(ICoffee coffeeToVend) : base()
      {
         this._coffeeToVend = coffeeToVend;
      }

      public virtual decimal Price
      {
         get;
      }

      private ICoffee _coffeeToVend;
   }
}
