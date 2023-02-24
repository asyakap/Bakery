using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
     public static int PastrySum(string count)
    {
      int count1 = Int32.Parse(count);
      int sum = 0;
      sum = count1 * 2 - 2 * (count1 / 4);
      return sum;
    }
  }
}