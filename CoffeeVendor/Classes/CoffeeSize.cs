using System;
using CoffeeVendor.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendor.Classes
{
   public class CoffeeSize : CoffeeDecorator     
   {
      public CoffeeSize(ICoffee coffeeToVend) : base(coffeeToVend)
      {
         this._coffeeToVend = coffeeToVend;
      }

      public void SetSize(string size)
      {
         this._sizePrice = Sizes[size];
      }

      public override decimal Price
      {
         get { return this._coffeeToVend.Price + this._sizePrice; }
      }

      private Dictionary<string, decimal> Sizes =
         new Dictionary<string, decimal>()
         {
            { "small", 1.75m },
            { "medium", 2.00m },
            { "large", 2.25m }
         };

      private ICoffee _coffeeToVend;
      private decimal _sizePrice;
   }
}
