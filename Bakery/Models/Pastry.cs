using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
     public static int PastrySum(string count1, string count2)
    {
      int cherryPie = Int32.Parse(count1);
      int croissant = Int32.Parse(count2);
      int sum = 0;
      sum = cherryPie * 3 - 3 * (cherryPie / 4) + croissant * 2 - 2 * (croissant / 4);
      return sum;
    }
  }
}