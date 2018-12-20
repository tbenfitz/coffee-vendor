using System;
using CoffeeVendor.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendor.Classes
{
   public class Coffee : ICoffee
   {
        public Coffee(ICoffee coffee)
        {
            this._coffee = coffee;
        }

        public decimal Price { get; }

      private ICoffee _coffee;
   }
}
