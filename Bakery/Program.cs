using System;
using Bakery.Models;
using System.Collections.Generic;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to our bakery!");
      Console.WriteLine("We have bread and pastries for order.");
      Console.WriteLine("1 loaf of bread is $5, 1 pastry is $2.");
      Console.WriteLine("Only today our special promotion! Buy 2, get 1 free for bread and Buy 3, get 1 free for pastries!");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("How many loafs of Bread would you like to purchase?");
      int sum = 0;
      string breadCount = Console.ReadLine();
      if (int.TryParse(breadCount, out int value))
      {
        sum = Bread.BreadSum(breadCount);
      }
      else
      {
        Console.WriteLine("Please enter a number > 0");
        breadCount = Console.ReadLine();
        sum = Bread.BreadSum(breadCount);
      }
      Console.WriteLine("How many pastries would you like to purchase?");
      string pastryCount = Console.ReadLine();
      if (int.TryParse(pastryCount, out int value1))
      {
        sum = sum + Pastry.PastrySum(pastryCount);
      }
      else
      {
        Console.WriteLine("Please enter a number > 0");
        pastryCount = Console.ReadLine();
        sum = sum + Pastry.PastrySum(pastryCount);
      }

      Console.WriteLine($"Your order total is ${sum}");
    }
  }
}