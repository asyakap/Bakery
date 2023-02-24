using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
     public static int BreadSum(string count)
    {
      int count1 = Int32.Parse(count);
      int sum = 0;
      sum = count1 * 5 - 5 * (count1 / 3);
      return sum;
    }
  }
}