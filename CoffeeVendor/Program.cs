using System;
using CoffeeVendor.Classes;
using CoffeeVendor.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeVendor
{
   class Program
   {
      /// <summary>

      /// Entry point into console application.

      /// </summary>

      static void Main()
      {
         ICoffee orderedCoffee = new CoffeeSize(new CoffeeSize(new Coffee()));

         ((CoffeeSize)orderedCoffee).SetSize("medium");

         orderedCoffee = new CoffeeSugar(orderedCoffee);
         orderedCoffee = new CoffeeSugar(orderedCoffee);
         orderedCoffee = new CoffeeSugar(orderedCoffee);

         orderedCoffee = new CoffeeCreamer(orderedCoffee);
         orderedCoffee = new CoffeeCreamer(orderedCoffee);
         orderedCoffee = new CoffeeCreamer(orderedCoffee);
         orderedCoffee = new CoffeeCreamer(orderedCoffee);

         Console.WriteLine(orderedCoffee.Price);
      }
   }  
}

