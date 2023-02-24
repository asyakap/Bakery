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
      Console.WriteLine("Only today our special promotion! Buy 2, get 1 free for each bread category and Buy 3, get 1 free for pastries!");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      int sum = 0;
      Console.WriteLine("The following breads are available for purchase: baguette - $3, white bread - $4, black bread - $5");

      Console.WriteLine("How many baguettes would you like to purchase?");
      string baguette = Console.ReadLine();
      if (!int.TryParse(baguette, out int value))
      {
        Console.WriteLine("Please enter a number > 0");
        baguette = Console.ReadLine();
      }

      Console.WriteLine("How many loaves of white bread would you like to purchase?");
      string white = Console.ReadLine();
      if (!int.TryParse(white, out int value1))
      {
        Console.WriteLine("Please enter a number > 0");
        white = Console.ReadLine();
      }

      Console.WriteLine("How many loaves of black bread would you like to purchase?");
      string black = Console.ReadLine();
      if (!int.TryParse(black, out int value2))
      {
        Console.WriteLine("Please enter a number > 0");
        black = Console.ReadLine();
      }
      sum = Bread.BreadSum(baguette, white, black);

      Console.WriteLine("How many pastries would you like to purchase?");
      string pastryCount = Console.ReadLine();
      if (int.TryParse(pastryCount, out int value3))
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